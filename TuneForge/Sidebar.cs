using ReaLTaiizor.Controls;
using Panel = System.Windows.Forms.Panel;

namespace TuneForge
{
    public sealed class Sidebar : Panel
    {
        /*
         * @brief Navigation buttons built on Labels
         * @details Every label is a navigation button , when clicked it will open a new form
         */
        private Label _mProfile = null!;
        private Label _mFavorite = null!;
        private Label _mSettings = null!;
        private Label _mContract = null!;
        private Label _mLanguage = null!;

        /*
         * @brief Cancel button built on PictureBox
         * @details PictureBox contains an image , when clicked it will close the sidebar
         */
        private PictureBox _mCancelIcon = null!;
        private Control? _toggleButton;

        public Sidebar(Control ? toggleButton = null)
        {
            // Using for OpenSideBar(button)
            _toggleButton = toggleButton;
            _toggleButton!.Visible = false;
            InitSidebar();
            InitLabels();
            InitImage();
        }

        private void InitSidebar()
        {
            BackColor = Color.FromArgb(24, 21, 19);
            BorderStyle = BorderStyle.FixedSingle;
            Dock = DockStyle.Left;
            Width = 200;
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

        private void InitImage()
        {
            _mCancelIcon = new PictureBox();
            _mCancelIcon.Image = Image.FromFile("D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\sidebar\\cancel.png");
            _mCancelIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            _mCancelIcon.Size = new Size(24, 24);
            _mCancelIcon.Location = new Point(32, 10);
            _mCancelIcon.Cursor = Cursors.Hand;
            _mCancelIcon.Click += (sender, e) =>
            {
                _toggleButton!.Visible = true;
                Parent?.Controls.Remove(this);
                Dispose();
            };
            Controls.Add(_mCancelIcon);
        }
      
    }
}