namespace TuneForge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LayoutMusicComponents();
        }
        
        private void Form1_ControlRemoved(object sender, ControlEventArgs e)
        {
            musicBar.Location = new Point(musicBar.Location.X - 80, musicBar.Location.Y);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //_musicBarOriginalLocation = musicBar.Location;
        }
    }
}