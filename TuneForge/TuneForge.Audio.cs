using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;
using Timer = System.Windows.Forms.Timer;

namespace TuneForge
{
    public partial class TuneForge : Form
    {
        private WaveOutEvent? outputDevice;
        private AudioFileReader? _audioFile;
        private readonly Timer _timer = new();
        private string? _currentMusicPath;
        private string? _newMusicPath;
        private bool _isMusicPlaying;
        private bool _isSoundOn;
        private bool _userIsDragging;
        private bool _IsSelectedSongFavorite;
        private bool _isRepeatMusic = false;

        public string CurrentMusicPath
        {
            get => _currentMusicPath ?? string.Empty;
            set => _currentMusicPath = value;
        }

        private void InitTimerMusic()
        {
            MusicTrackBar.Minimum = 0;
            MusicTrackBar.Maximum = 1000;
            MusicTrackBar.Value = 0;
            MusicTrackBar.MouseDown += (s, e) => _userIsDragging = true;
            MusicTrackBar.MouseUp += MusicTrackBar_MouseUp;
            _timer.Interval = 500;
            _timer.Tick += TimerTime_Tick;
        }

        private Image? GetAlbumArt(string path)
        {
            if (!File.Exists(path))
            {
                return null;
            }

            using var tagFile = TagLib.File.Create(path);
            if (tagFile.Tag.Pictures.Length == 0)
            {
                return null;
            }

            var bin = tagFile.Tag.Pictures[0].Data.Data;
            if (bin.Length == 0)
            {
                return null;
            }

            using var ms = new MemoryStream(bin);
            return Image.FromStream(ms);
        }

        public void UpdateAlbumArt(string path)
        {
            var albumImage = GetAlbumArt(path);
            if (albumImage == null)
            {
                return;
            }
            MusicLogo.Image?.Dispose();
            MusicLogo.Image = albumImage;
            MusicLogo.BackColor = Color.Transparent;
        }

        public void TakeArtistSongName(string path)
        {
            try
            {
                var file = TagLib.File.Create(path);
                string artist = file.Tag.FirstPerformer ?? string.Empty;
                string title = file.Tag.Title ?? string.Empty;

                if (string.IsNullOrWhiteSpace(artist) || string.IsNullOrWhiteSpace(title))
                {
                    var fileName = Path.GetFileNameWithoutExtension(path);
                    var parts = fileName.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 2)
                    {
                        artist = string.IsNullOrWhiteSpace(artist) ? parts[0].Trim() : artist;
                        title = string.IsNullOrWhiteSpace(title) ? parts[1].Trim() : title;
                    }
                    else
                    {
                        title = fileName;
                    }
                }

                nameArtist.Text = string.IsNullOrWhiteSpace(artist) ? "" : artist;
                nameSong.Text = string.IsNullOrWhiteSpace(title) ? "" : title;
            }
            catch
            {
                nameArtist.Text = "";
                nameSong.Text = "";
            }
        }

        private void MusicTrackBar_MouseUp(object? sender, MouseEventArgs e)
        {
            if (_audioFile == null)
            {
                return;
            }
            double frac = MusicTrackBar.Value / (double)MusicTrackBar.Maximum;
            _audioFile.CurrentTime = TimeSpan.FromSeconds(frac * _audioFile.TotalTime.TotalSeconds);
            startMusicLabel.Text = $@"{_audioFile.CurrentTime:mm\:ss}";
            _userIsDragging = false;
        }

        private void TimerTime_Tick(object? sender, EventArgs e)
        {
            if (_audioFile == null || !_isMusicPlaying || _userIsDragging)
            {
                return;
            }
            double progress = _audioFile.CurrentTime.TotalSeconds / _audioFile.TotalTime.TotalSeconds;
            MusicTrackBar.Value = (int)(progress * MusicTrackBar.Maximum);
            startMusicLabel.Text = $@"{_audioFile.CurrentTime:mm\:ss}";
            endMusicLabel.Text = $@"{_audioFile.TotalTime:mm\:ss}";
        }

        private void StatusVolumeSound_Click(object sender, EventArgs e)
        {
            if (outputDevice == null)
            {
                MessageBox.Show("No music device initialized.", "TuneForge",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _isSoundOn = !_isSoundOn;
            outputDevice.Volume = _isSoundOn ? 1f : 0f;
            StatusVolumeSound.Image = Image.FromFile(
                _isSoundOn
                ? "D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\menu\\volume-high_b.png"
                : "D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\menu\\volume-high_c.png");
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
                StopAndDisposeCurrentMusic();
            }
            
            if (outputDevice == null || _audioFile == null)
            {
                try
                {
                    TakeArtistSongName(CurrentMusicPath);
                    _audioFile = new AudioFileReader(CurrentMusicPath);
                    outputDevice = new WaveOutEvent();
                    outputDevice.Init(_audioFile);
                    outputDevice.PlaybackStopped += OnPlaybackStopped;
                    _isSoundOn = true;
                    outputDevice.Volume = 1f;
                    outputDevice.Play();
                    _isMusicPlaying = true;
                    UpdateAlbumArt(CurrentMusicPath);
                    _timer.Start();
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
                    _timer.Stop();
                    outputDevice.Pause();
                }
                else
                {
                    _timer.Start();
                    outputDevice.Play();
                }
                _isMusicPlaying = !_isMusicPlaying;
            }
        }

        private void StopAndDisposeCurrentMusic()
        {
            _timer.Stop();

            if (outputDevice != null)
            {
                outputDevice.PlaybackStopped -= OnPlaybackStopped;
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
            }

            if (_audioFile != null)
            {
                _audioFile.Dispose();
                _audioFile = null;
            }

            _isMusicPlaying = false;
            MusicTrackBar.Value = 0;
            startMusicLabel.Text = "00:00";
            endMusicLabel.Text = "00:00";

            MusicLogo.Image?.Dispose();
            MusicLogo.Image = null;
            MusicLogo.BackColor = Color.DimGray;
        }

        private void OnPlaybackStopped(object? sender, StoppedEventArgs e)
        {
            _timer.Stop();

            if (_isMusicPlaying && _audioFile != null && outputDevice != null)
            {
                _timer.Start();
                outputDevice.Play();
                _isMusicPlaying = true;
            }
            else
            {
                _isMusicPlaying = false;
            }
        }

        private void startMusic(object sender, EventArgs e)
        {
            if (_audioFile != null)
            {
                _audioFile.CurrentTime = TimeSpan.Zero;
                outputDevice!.Pause();
            }
        }

        private void endMusic(object sender, EventArgs e)
        {
            if (_audioFile != null)
            {
                _audioFile.CurrentTime = _audioFile.TotalTime - TimeSpan.FromMilliseconds(500);
            }
        }

        private void selectFavoriteSongToPlayList(object sender, EventArgs e)
        {
            if (outputDevice == null || _audioFile == null)
            {
                return;
            }

            _IsSelectedSongFavorite = !_IsSelectedSongFavorite;
            selectFavoriteSong.Image = Image.FromFile(
                _IsSelectedSongFavorite
                ? "D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\sidebar\\favorite_a.png"
                : "D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\menu\\favorite_b.png");
        }

        private void repeatSong(object sender , EventArgs e)
        {
            _audioFile!.Position = 0;
            _timer.Start();
            outputDevice!.Play();
            _isMusicPlaying = true;
        }
        
    }
}
