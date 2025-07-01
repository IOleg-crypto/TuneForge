using NAudio.Wave;
using Timer = System.Windows.Forms.Timer;

namespace TuneForge
{
    public partial class Form1
    {
        private WaveOutEvent? outputDevice;
        private AudioFileReader? audioFile;
        private string? _currentMusicPath;
        private bool _isMusicPlaying;

        public string CurrentMusicPath
        {
            get => _currentMusicPath ?? string.Empty;
            set => _currentMusicPath = value;
        }

        private void OnClickMusic(object sender, EventArgs args)
        {
            if (outputDevice == null || audioFile == null)
            {
                if (string.IsNullOrEmpty(CurrentMusicPath))
                {
                    MessageBox.Show("No music selected");
                    return;
                }
                try
                {
                    audioFile = new AudioFileReader(CurrentMusicPath);
                    outputDevice = new WaveOutEvent();
                    outputDevice.Init(audioFile);
                    outputDevice.PlaybackStopped += OnPlaybackStopped;
                    outputDevice.Play();
                    _isMusicPlaying = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error playing audio: {ex.Message}");
                }
            }
            else
            {
                if (_isMusicPlaying)
                {
                    outputDevice.Pause();
                    _isMusicPlaying = false;
                }
                else
                {
                    outputDevice.Play();
                    _isMusicPlaying = true;
                }
            }
        }
        private void OnPlaybackStopped(object? sender, StoppedEventArgs e)
        {
            outputDevice?.Dispose();
            outputDevice = null;

            audioFile?.Dispose();
            audioFile = null;

            _isMusicPlaying = false;
        }
        
    }
}
