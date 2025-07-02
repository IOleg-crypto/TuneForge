using System;
using System.Windows.Forms;
using NAudio.Wave;
using Timer = System.Windows.Forms.Timer;

namespace TuneForge
{
    public partial class TuneForge
    {
        private WaveOutEvent? outputDevice;
        private AudioFileReader? audioFile;
        private PictureBox _albumArt;
        private readonly Timer _timer = new();
        private string? _currentMusicPath;
        private string? _newMusicPath;
        private bool _isMusicPlaying;
        private bool _isSoundOn;
        private bool _userIsDragging;
        
        private Image? GetAlbumArt(string path)
        {
            try
            {
                if (!File.Exists(path))
                    return null;

                using var tagFile = TagLib.File.Create(path);
                if (tagFile.Tag.Pictures.Length > 0)
                {
                    var bin = tagFile.Tag.Pictures[0].Data.Data;
                    if (bin.Length == 0) return null;

                    using var ms = new MemoryStream(bin);
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading album art: " + ex.Message);
            }

            return null;
        }
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
            MusicTrackBar.MouseDown += (s, e) => _userIsDragging = true;
            MusicTrackBar.MouseUp   += MusicTrackBar_MouseUp;
            _timer.Interval = 500;
            _timer.Tick += TimerTime_Tick;
        }
        
        private void MusicTrackBar_MouseUp(object? sender, MouseEventArgs e)
        {
            if (audioFile == null) return;

            double frac = MusicTrackBar.Value / (double)MusicTrackBar.Maximum;
            audioFile.CurrentTime = TimeSpan.FromSeconds(frac * audioFile.TotalTime.TotalSeconds);
            startMusicLabel.Text = $"{audioFile.CurrentTime:mm\\:ss}";

            _userIsDragging = false;
        }

        private void TimerTime_Tick(object? sender, EventArgs e)
        {
            if (audioFile == null || !_isMusicPlaying || _userIsDragging)
                return;

            double progress = audioFile.CurrentTime.TotalSeconds / audioFile.TotalTime.TotalSeconds;
            MusicTrackBar.Value = (int)(progress * MusicTrackBar.Maximum);
            startMusicLabel.Text = $@"{audioFile.CurrentTime:mm\:ss}";
            endMusicLabel  .Text = $@"{audioFile.TotalTime:mm\:ss}";
        }

        private void MusicTrackBar_Scroll(object? sender, EventArgs e)
        {
            if (audioFile == null) return;
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

            if (_isSoundOn)
            {
                outputDevice.Volume = 0f;
                StatusVolumeSound.Image =
                    Image.FromFile("D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\menu\\volume-high_c.png");
                _isSoundOn = false;
            }
            else
            {
                outputDevice.Volume = 1f;
                StatusVolumeSound.Image =
                    Image.FromFile("D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\menu\\volume-high_b.png");
                _isSoundOn = true;
            }
            
        }

        private void OnClickMusic(object sender, EventArgs args)
        {
            if (string.IsNullOrEmpty(CurrentMusicPath))
            {
                MessageBox.Show("No music selected", "TuneForge",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (_newMusicPath != CurrentMusicPath)
            {
                StopCurrentMusic();
            }

            if (outputDevice == null || audioFile == null)
            {
                try
                {
                    audioFile = new AudioFileReader(CurrentMusicPath);
                    outputDevice = new WaveOutEvent();
                    outputDevice.Init(audioFile);
                    outputDevice.PlaybackStopped += OnPlaybackStopped;
                    outputDevice.Volume = 1f;
                    _isSoundOn = true;

                    outputDevice.Play();
                    _isMusicPlaying = true;
                    _timer.Start();

                    var albumImage = GetAlbumArt(CurrentMusicPath);
                    _albumArt = new PictureBox()
                    {
                        SizeMode = PictureBoxSizeMode.AutoSize
                    };
                    if (albumImage != null)
                    {
                        MusicLogo.Image = albumImage;
                        MusicLogo.BackColor = Color.Transparent;
                    }

                    _newMusicPath = CurrentMusicPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error playing audio: {ex.Message}", "TuneForge",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
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
        // Allow user to play another music, without listen current and then changing
        private void StopCurrentMusic()
        {
            _timer.Stop();
            outputDevice?.Stop();
            outputDevice?.Dispose();
            audioFile?.Dispose();
            outputDevice = null;
            audioFile = null;
            _isMusicPlaying = false;

            MusicTrackBar.Value = 0;
            startMusicLabel.Text = "00:00";
            endMusicLabel.Text = "00:00";

            MusicLogo.Image = null;
            MusicLogo.BackColor = Color.DimGray;
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
            endMusicLabel.Text = "00:00";
        }
        private void startMusic(object sender, EventArgs e)
        {
            if (audioFile != null) audioFile.CurrentTime = TimeSpan.Zero;
        }
        private void endMusic(object sender, EventArgs e)
        {
            if (audioFile != null) audioFile.CurrentTime = audioFile.TotalTime - TimeSpan.FromMilliseconds(500);
        }
    }
}
