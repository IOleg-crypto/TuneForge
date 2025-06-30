namespace TuneForge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void openSideBar(object sender, EventArgs e)
        {
            if (OpenSideBar == null || OpenSideBar.IsDisposed || !OpenSideBar.IsHandleCreated)
                return;

            if (Controls.OfType<Sidebar>().Any())
            {
                return;
            }
            Sidebar sidebar = new Sidebar(OpenSideBar);
            Controls.Add(sidebar); 
        }
    }
}