namespace TuneForge
{
    public partial class TuneForge : Form
    {
        private List<Control>? _savedControls;

        public List<Control>? SavedControls
        {
            get => _savedControls;
            set => _savedControls = value;
        }
        private void TuneForgeLoad(object sender, EventArgs e)
        { 
            SavedControls = ForgePanel.Controls.Cast<Control>().ToList();
        }
        public void ShowUserControl(UserControl control)
        {
            ForgePanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            ForgePanel.Controls.Add(control);
        }
        
    }
}