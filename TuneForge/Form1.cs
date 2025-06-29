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
            Sidebar sidebar = new Sidebar(OpenSideBar);
            if (!Controls.OfType<Sidebar>().Any())
            {
                Controls.Add(sidebar); 
            }
            
            
        }
    }
}