namespace TuneForge
{
    public partial class TuneForge : Form
    {
        private Dictionary<Control, Rectangle> originalControlBounds;
        private Dictionary<Control, float> originalFontSizes;
        private Size _originalClientSize;

        private const float MIN_FONT = 6f;
        private const float MAX_FONT = 15f;
        
      
        private void TuneForge_Load(object? sender, EventArgs e)
        {
            // Зберігаємо початкові властивості
            _originalClientSize = this.ClientSize;
            originalControlBounds = new Dictionary<Control, Rectangle>();
            originalFontSizes = new Dictionary<Control, float>();

            sidebar = this.Controls.OfType<Sidebar>().FirstOrDefault()!;
            StoreOriginalBounds(this);
            // Прив'язуємо обробники завантаження та зміни розміру
            this.Load += TuneForge_Load;
            this.Resize += TuneForge_Resize;
        }

        private void StoreOriginalBounds(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (!originalControlBounds.ContainsKey(ctrl)) 
                {
                    Rectangle bounds = ctrl.Bounds;
                    
                    if (sidebar?.IsHandleCreated == true && ctrl != sidebar)
                    {
                        bounds.X += 15; // або bounds.X += 15; — залежно від твого дизайну
                    }

                    
                    

                    originalControlBounds[ctrl] = bounds;
                    originalFontSizes[ctrl] = ctrl.Font.Size;
                }

                if (ctrl.HasChildren)
                    StoreOriginalBounds(ctrl);
            }
        }

        private void TuneForge_Resize(object? sender, EventArgs e)
        {
            MinimumSize = new Size(960, 480);
            float xRatio = (float)ClientSize.Width / _originalClientSize.Width;
            float yRatio = (float)ClientSize.Height / _originalClientSize.Height;
            float scale = Math.Min(xRatio, yRatio);

            foreach (var entry in originalControlBounds)
            {
                Control ctrl = entry.Key;
                if (ctrl == sidebar)
                    continue;

                Rectangle orig = entry.Value;
                int offsetX = (sidebar?.IsHandleCreated == true ? 50 : 0);

                int newX = offsetX + (int)(orig.X * xRatio);
                int newY = (int)(orig.Y * yRatio);
                int newW = (int)(orig.Width * xRatio);
                int newH = (int)(orig.Height * yRatio);
                
                //ctrl.Bounds = new Rectangle(newX, newY, newW, newH);
                ctrl.Location = new Point(newX, newY);
                ctrl.Size = new Size(newW, newH);

                if (ctrl == musicBar)
                {
                    ctrl.Location = new Point(newX + 20, newY);
                }
                

                var originalFont = originalFontSizes[ctrl];
                var newFont = Math.Clamp(originalFont * scale, MIN_FONT, MAX_FONT);
                ctrl.Font = new Font(ctrl.Font.FontFamily, newFont, ctrl.Font.Style);
            }
        }
        
        private void LayoutMusicComponents()
        {
            this.Load += TuneForge_Load;
            this.Resize += TuneForge_Resize;
        }

        private void TuneForge_ResizeBegin(object sender, EventArgs e)
        {
            Control[] controlsToShift =
            [
                musicBar, startMusicLabel, endMusicLabel, MusicTrackBar,
                StatusVolumeSound, MusicLogo, nameSong, nameArtist,
                Shuffle, selectFavoriteSong, repeatPlayList
            ];

            foreach (var ctrl in controlsToShift)
            {
                ctrl.Anchor = AnchorStyles.Bottom;
            }
        }

        private void TuneForge_ResizeEnd(object sender, EventArgs e)
        {
            Control[] controlsToShift =
            [
                musicBar, startMusicLabel, endMusicLabel, MusicTrackBar,
                StatusVolumeSound, MusicLogo, nameSong, nameArtist,
                Shuffle, selectFavoriteSong, repeatPlayList
            ];

            foreach (var ctrl in controlsToShift)
            {
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

            foreach (var ctrl in controlsToShift)
            {
                ctrl.Location = ctrl.Location with { X = ctrl.Location.X - 75 };
            }
        }
    }
}
