namespace TuneForge
{
    public partial class TuneForge
    {
        private Dictionary<Control, Rectangle> originalControlBounds;
        private Size _originalSize;

        private void TuneForge_Load(object? sender, EventArgs e)
        {
            _originalSize = this.Size;
            originalControlBounds = new Dictionary<Control, Rectangle>();

            foreach (Control ctrl in this.Controls)
            {
                originalControlBounds[ctrl] = ctrl.Bounds;
            }
        }
        
        private void TuneForge_Resize(object? sender, EventArgs e)
        {
            float xRatio = (float)this.Width / _originalSize.Width;
            float yRatio = (float)this.Height / _originalSize.Height;

            foreach (var entry in originalControlBounds)
            {
                Control ctrl = entry.Key;
                Rectangle originalBounds = entry.Value;

                int newX = (int)(originalBounds.X * xRatio);
                int newY = (int)(originalBounds.Y * yRatio);
                int newWidth = (int)(originalBounds.Width * xRatio);
                int newHeight = (int)(originalBounds.Height * yRatio);

                ctrl.Bounds = new Rectangle(newX, newY, newWidth, newHeight);

                float newFontSize = ctrl.Font.Size * Math.Min(xRatio, yRatio);
                ctrl.Font = new Font(ctrl.Font.FontFamily, Math.Max(6, newFontSize));
            }
        }

        
        private void LayoutMusicComponents()
        {
            labelProgram.Anchor = AnchorStyles.Right | AnchorStyles.Top;

            Control[] bottomAnchoredControls =
            [
                musicBar, MusicTrackBar, startMusicLabel, endMusicLabel,
                StatusVolumeSound, MusicLogo, nameSong, nameArtist,
                selectFavoriteSong, repeatPlayList, Shuffle
            ];

            foreach (var ctrl in bottomAnchoredControls)
                ctrl.Anchor = AnchorStyles.Bottom;

            this.Load += TuneForge_Load;
            this.Resize += TuneForge_Resize;

            if (WindowState == FormWindowState.Normal)
            {
                
            }
        }

        private void TuneForge_ResizeBegin(object sender, EventArgs e)
        {
            labelProgram.Anchor = AnchorStyles.Right | AnchorStyles.Top;

            Control[] bottomAnchoredControls =
            [
                musicBar, MusicTrackBar, startMusicLabel, endMusicLabel,
                StatusVolumeSound, selectFavoriteSong, repeatPlayList, Shuffle
            ];

            foreach (var ctrl in bottomAnchoredControls)
                ctrl.Anchor = AnchorStyles.Bottom;
        }

        private void TuneForge_ResizeEnd(object sender, EventArgs e)
        {
            labelProgram.Dock = DockStyle.None;
            labelProgram.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            Control[] allDockedControls = {
                musicBar, MusicTrackBar, startMusicLabel, endMusicLabel,
                StatusVolumeSound, selectFavoriteSong, repeatPlayList, Shuffle
            };

            foreach (var ctrl in allDockedControls)
            {
                ctrl.Dock = DockStyle.None;
                ctrl.Anchor = AnchorStyles.Bottom;
            }
        }
        private void TuneForge_ControlRemoved(object sender, ControlEventArgs e)
        {
            Control[] controlsToShift =
            [
                musicBar, startMusicLabel, endMusicLabel, MusicTrackBar,
                StatusVolumeSound, MusicLogo, nameSong, nameArtist,
                Shuffle, selectFavoriteSong, repeatPlayList
            ];

            foreach (var control in controlsToShift)
            {
                control.Location = new Point(control.Location.X - 80, control.Location.Y);
            }
        }
        
    }
}