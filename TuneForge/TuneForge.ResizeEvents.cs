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
            // Store initial form size and control bounds
            _originalClientSize = ClientSize;
            originalControlBounds = new Dictionary<Control, Rectangle>();
            originalFontSizes = new Dictionary<Control, float>();

            // Get the existing sidebar if already present
            sidebar = this.Controls.OfType<Sidebar>().FirstOrDefault()!;

            // Store bounds and fonts of all controls recursively
            StoreOriginalBounds(this);

            // Register form load and resize handlers
            this.Load += TuneForge_Load;
            this.ForgePanel.Resize += TuneForge_Resize;
        }

        private void StoreOriginalBounds(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (!originalControlBounds.ContainsKey(ctrl)) 
                {
                    Rectangle bounds = ctrl.Bounds;

                    // Optional offset based on sidebar visibility
                    if (sidebar?.Created == true && ctrl != sidebar)
                    {
                        bounds.X += 10;
                    }

                    originalControlBounds[ctrl] = bounds;
                    originalFontSizes[ctrl] = ctrl.Font.Size;
                }

                // Recursively store children
                if (ctrl.HasChildren)
                {
                    StoreOriginalBounds(ctrl);
                }
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
                if (ctrl == sidebar && ctrl == OpenSideBar)
                    continue;

                Rectangle orig = entry.Value;
                int offsetX = (sidebar?.IsHandleCreated == true ? 65 : 0);

                int newX = offsetX + (int)(orig.X * xRatio);
                int newY = (int)(orig.Y * yRatio);
                int newW = (int)(orig.Width * xRatio);
                int newH = (int)(orig.Height * yRatio);

                ctrl.Size = new Size(newW, newH); // Resize first

                // Center the musicBar horizontally
                if (ctrl == musicBar)
                {
                    int sidebarOffset = sidebar?.Created == true ? 65 : 0;
                    int centerX = sidebarOffset + (ClientSize.Width - sidebarOffset - ctrl.Width) / 2;

                    if (Width <= 1000)
                    {
                        centerX -= 210;
                    }
                    if (Width >= 1600)
                    {
                        centerX -= 5;
                    }
                    Console.WriteLine($@"the resolution {Width} x {Height}");


                    ctrl.Location = new Point(centerX + 65, newY); // Final centered position
                    ctrl.Size = new Size(newW, newH);
                }

                if (ctrl == labelProgram)
                {
                    int margin = 20;
                    int x = ClientSize.Width - ctrl.Width - margin;
                    ctrl.Location = new Point(x, newY);
                    
                }

                if (ctrl == MusicLogo || ctrl == nameArtist || ctrl == nameSong)
                {
                    int sidebarOffset = (sidebar?.Created == true ? 65 : 0);
                    int centerX = sidebarOffset + (ClientSize.Width - sidebarOffset - ctrl.Width) / 2;
                    if (Width >= 1400)
                    {
                        centerX -= 15;
                    }
                    else
                    {
                        centerX += 10;
                    }
                    
                    Console.WriteLine($@"the resolution {Width} x {Height}");
                    ctrl.Location = new Point(centerX, newY); // Final centered position
                    Console.WriteLine($@"{ctrl.Size.Width} , {ctrl.Size.Height}");
                    ctrl.Size = new Size(newW, newH);
                        
                }
                
                // Default layout for other controls
                else
                {
                    ctrl.Location = new Point(newX, newY);
                }

                // Resize font within min/max bounds
                var originalFont = originalFontSizes[ctrl];
                var newFont = Math.Clamp(originalFont * scale, MIN_FONT, MAX_FONT);
                ctrl.Font = new Font(ctrl.Font.FontFamily, newFont, ctrl.Font.Style);
            }
        }

        private void LayoutMusicComponents()
        {
            // Assign resize logic on load
            this.Load += TuneForge_Load;
            this.Resize += TuneForge_Resize;
        }

        private void TuneForge_ResizeBegin(object sender, EventArgs e)
        {
            // Anchor bottom-aligned controls before resizing
            Control[] controlsToShift =
            [
                musicBar, startMusicLabel, endMusicLabel, MusicTrackBar,
                StatusVolumeSound, MusicLogo, nameSong, nameArtist,
                Shuffle, selectFavoriteSong, repeatPlayList , labelProgram
            ];

            foreach (var ctrl in controlsToShift)
            {
                ctrl.Anchor = AnchorStyles.Bottom;
            }
        }

        private void TuneForge_ResizeEnd(object sender, EventArgs e)
        {
            // Reapply anchor after resizing
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
            // Adjust X-position of controls when sidebar is removed
            Control[] controlsToShift =
            [
                musicBar, startMusicLabel, endMusicLabel, MusicTrackBar,
                StatusVolumeSound, MusicLogo, nameSong, nameArtist,
                Shuffle, selectFavoriteSong, repeatPlayList , labelProgram
            ];

#if DEBUG
            MessageBox.Show("Control removed");
#endif

            foreach (var ctrl in controlsToShift)
            {
                ctrl.Location = ctrl.Location with { X = ctrl.Location.X - 65 };
            }
        }
        private void ForgePanelControlRemoved(object sender, ControlEventArgs e)
        {
            // Adjust X-position of controls when sidebar is removed
            Control[] controlsToShift =
            [
                musicBar, startMusicLabel, endMusicLabel, MusicTrackBar,
                StatusVolumeSound, MusicLogo, nameSong, nameArtist,
                Shuffle, selectFavoriteSong, repeatPlayList , labelProgram
            ];

#if DEBUG
            MessageBox.Show("Control removed");
#endif

            foreach (var ctrl in controlsToShift)
            {
                ctrl.Location = ctrl.Location with { X = ctrl.Location.X - 65 };
            }
        }
    }
}
