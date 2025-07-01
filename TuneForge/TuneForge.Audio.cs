using System;
using System.Windows.Forms;
using NAudio.Wave;
using Timer = System.Windows.Forms.Timer;

namespace TuneForge
{
    public partial class TuneForge : Form
    {
        private WaveOutEvent? outputDevice;
        private AudioFileReader? audioFile;
        private readonly Timer _timer = new Timer();
        private string? _currentMusicPath;
        private bool _isMusicPlaying;
        private bool _isSoundOn;
        private bool userIsDragging = false;

        public string CurrentMusicPath
        {
            get => _currentMusicPath ?? string.Empty;
            set => _currentMusicPath = value;
        }

        private void InitTimerMusic()
        {
            // TrackBar
            MusicTrackBar.Minimum = 0;
            MusicTrackBar.Maximum = 1000;
            MusicTrackBar.Value = 0;
            MusicTrackBar.MouseDown += (s, e) => userIsDragging = true;
            MusicTrackBar.MouseUp   += MusicTrackBar_MouseUp;

            // Таймер оновлення
            _timer.Interval = 500;
            _timer.Tick += TimerTime_Tick;
        }
        
        private void MusicTrackBar_MouseUp(object? sender, MouseEventArgs e)
        {
            if (audioFile == null) return;

            double frac = MusicTrackBar.Value / (double)MusicTrackBar.Maximum;
            audioFile.CurrentTime = TimeSpan.FromSeconds(frac * audioFile.TotalTime.TotalSeconds);
            startMusicLabel.Text = $"{audioFile.CurrentTime:mm\\:ss}";

            userIsDragging = false;
        }

        private void TimerTime_Tick(object? sender, EventArgs e)
        {
            if (audioFile == null || !_isMusicPlaying || userIsDragging)
                return;

            double progress = audioFile.CurrentTime.TotalSeconds / audioFile.TotalTime.TotalSeconds;
            MusicTrackBar.Value = (int)(progress * MusicTrackBar.Maximum);
            startMusicLabel.Text = $"{audioFile.CurrentTime:mm\\:ss}";
            endMusicLabel  .Text = $"{audioFile.TotalTime:mm\\:ss}";
        }

        private void MusicTrackBar_Scroll(object? sender, EventArgs e)
        {
            if (audioFile == null) return;

            // Стрибаємо в ту точку, куди повзунок перемістили
            double frac = MusicTrackBar.Value / (double)MusicTrackBar.Maximum;
            audioFile.CurrentTime = TimeSpan.FromSeconds(frac * audioFile.TotalTime.TotalSeconds);
            startMusicLabel.Text = $"{audioFile.CurrentTime:mm\\:ss}";
        }

        private void StatusVolumeSound_Click(object sender, EventArgs e)
        {
            if (outputDevice == null)
            {
                MessageBox.Show("No music device initialized.", "TuneForge",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            outputDevice.Volume = _isSoundOn ? 0f : 1f;
            _isSoundOn         = !_isSoundOn;
        }

        private void OnClickMusic(object sender, EventArgs args)
        {
            // Перший старт
            if (outputDevice == null || audioFile == null)
            {
                if (string.IsNullOrEmpty(CurrentMusicPath))
                {
                    MessageBox.Show("No music selected", "TuneForge",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    audioFile = new AudioFileReader(CurrentMusicPath);
                    outputDevice = new WaveOutEvent();
                    outputDevice.Init(audioFile);
                    outputDevice.PlaybackStopped += OnPlaybackStopped;
                    outputDevice.Volume = 1f;
                    _isSoundOn = true;

                    // скидаємо позицію тільки один раз
                    audioFile.Position = 0;
                    outputDevice.Play();
                    _isMusicPlaying = true;
                    _timer.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error playing audio: {ex.Message}", "TuneForge",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Пауза / Відновлення
                if (_isMusicPlaying)
                {
                    outputDevice.Pause();
                    _isMusicPlaying = false;
                    _timer.Stop();
                }
                else
                {
                    outputDevice.Play();
                    _isMusicPlaying = true;
                    _timer.Start();
                }
            }
        }

        private void OnPlaybackStopped(object? sender, StoppedEventArgs e)
        {
            _timer.Stop();
            outputDevice?.Dispose();
            audioFile?.Dispose();
            outputDevice = null;
            audioFile = null;
            _isMusicPlaying = false;

            MusicTrackBar.Value   = 0;
            startMusicLabel.Text = "00:00";
            endMusicLabel  .Text = "00:00";
        }
    }
}
