namespace TuneForge
{
    public partial class TuneForge
    {
        private readonly int _sidebarOffset = 85; // Default offset
        private bool _isSidebarOpen;

        private void openSideBar(object sender, EventArgs e)
        {
            if (_isSidebarOpen)
            {
                var existingSidebar = Controls.OfType<Sidebar>().FirstOrDefault();
                if (existingSidebar != null)
                {
                    
                    Controls.Remove(existingSidebar);
                    existingSidebar.Dispose();
                }
                _isSidebarOpen = false;
                return;
            }

            if (OpenSideBar == null || OpenSideBar.IsDisposed || !OpenSideBar.IsHandleCreated)
            {
                return;
            }

            if (IsDisposed || !IsHandleCreated)
            {
                return;
            }

            Sidebar sidebar = new Sidebar(this , OpenSideBar);
            Controls.Add(sidebar);
            sidebar.InitFullscreenResize();
            

            if (sidebar.IsHandleCreated)
            {
                ShiftMusicBar(_sidebarOffset);

                _isSidebarOpen = true;
            }
        }

        private void ShiftMusicBar(int offsetX)
        {
            Control[] controlsToShift =
            [
                musicBar, startMusicLabel, endMusicLabel, MusicTrackBar,
                StatusVolumeSound, MusicLogo, nameSong, nameArtist,
                Shuffle, selectFavoriteSong, repeatPlayList
            ];

            foreach (var control in controlsToShift)
            {
                control.Location = new Point(control.Location.X + offsetX, control.Location.Y);
            }
        }
    }
}