namespace TuneForge
{
    public partial class Form1
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
            if (musicBar != null)
                musicBar.Location = new Point(musicBar.Location.X + offsetX, musicBar.Location.Y);

            if (startMusicLabel != null)
                startMusicLabel.Location = new Point(startMusicLabel.Location.X + offsetX, startMusicLabel.Location.Y);

            if (endMusicLabel != null)
                endMusicLabel.Location = new Point(endMusicLabel.Location.X + offsetX, endMusicLabel.Location.Y);

            if (MusicTrackBar != null)
                MusicTrackBar.Location = new Point(MusicTrackBar.Location.X + offsetX, MusicTrackBar.Location.Y);
        }
    }
}