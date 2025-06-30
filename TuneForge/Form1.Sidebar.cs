namespace TuneForge
{
    public partial class Form1
    {
        private readonly int _sidebarOffset = 85;
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
            Sidebar sidebar = new Sidebar(OpenSideBar);
            Controls.Add(sidebar);

            if (sidebar.IsHandleCreated)
            {
                ShiftMusicBar(_sidebarOffset);

                _isSidebarOpen = true;
            }
        }

        private void ShiftMusicBar(int offsetX)
        {
            musicBar.Location = new Point(musicBar.Location.X + offsetX, musicBar.Location.Y);
        }
    }
}