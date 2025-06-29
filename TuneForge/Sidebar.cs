namespace TuneForge;

public class Sidebar : Panel
{
    private Label _mProfile;
    private Label _mFavorite;
    private Label _mSettings;
    private Label _mContract;
    private Label _mLanguage;
    private Image _mCancelIcon;

    public Sidebar()
    {
        BackColor = Color.FromArgb(24, 21, 19);
        BorderStyle = BorderStyle.FixedSingle;
        Dock = DockStyle.Left;
        Width = 200;
        InitLabels(); 
    }

    private void InitLabels()
    {
        _mProfile = CreateSidebarLabel("Profile", 50);
        _mFavorite = CreateSidebarLabel("Favorite", 120);
        _mSettings = CreateSidebarLabel("Settings", 500);
        _mLanguage = CreateSidebarLabel("Language", 250);
        _mContract = CreateSidebarLabel("Contract", 450);

        Controls.Add(_mProfile);
        Controls.Add(_mFavorite);
        Controls.Add(_mSettings);
        Controls.Add(_mContract);
        Controls.Add(_mLanguage);
    }

    private Label CreateSidebarLabel(string text, int top)
    {
        Label lbl = new Label();
        lbl.Text = text;
        lbl.ForeColor = Color.White;
        lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
        lbl.Location = new Point(35, top);
        lbl.AutoSize = true;
        lbl.Cursor = Cursors.Hand;
        return lbl;
    }
}