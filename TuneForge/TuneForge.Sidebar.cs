namespace TuneForge
{
    public partial class TuneForge
    {
        private readonly int _sidebarOffset = 60; // Default offset
        private bool _isSidebarOpen;
        private Sidebar sidebar;

        public void openSideBar(object sender, EventArgs e)
        {
            if (_isSidebarOpen)
            {
                var existingSidebar = Controls.OfType<Sidebar>().FirstOrDefault();
                if (existingSidebar != null)
                {
                    ForgePanel.Controls.Remove(existingSidebar);
                    existingSidebar.Dispose();
                }
                _isSidebarOpen = false;
                return;
            }

            
            sidebar = new Sidebar(this , OpenSideBar);
            ForgePanel.Controls.Add(sidebar);
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
                Shuffle, selectFavoriteSong, repeatPlayList , labelProgram
            ];

            foreach (var control in controlsToShift)
            {
                control.Location = new Point(control.Location.X + offsetX, control.Location.Y);
            }
        }
    }
}