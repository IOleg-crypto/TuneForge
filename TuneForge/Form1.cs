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
            int sidebarCount = Controls.OfType<Sidebar>().Count();
            Sidebar sidebar = new Sidebar();
            if (sidebarCount < 1)
            {
                Controls.Add(sidebar);
            }

            if (!Controls.Contains(sidebar))
            {
                OpenSideBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                OpenSideBar.Visible = false;
                
                
            }
        }
    }
}