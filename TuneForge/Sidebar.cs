using System.Diagnostics;
using System.Drawing.Text;
using Panel = System.Windows.Forms.Panel;

namespace TuneForge
{
    public sealed class Sidebar : Panel
    {
        private List<SidebarItem> _items = new();
        private PictureBox _cancelIcon = null!;
        private Control? _toggleButton;
        private Form ? _form;
        
        public Sidebar(Form? form , Control? toggleButton = null)
        {
            SetForm(form);
            IsToggleButtonVisible(toggleButton);
            InitSidebar();
            InitItems();
            InitCancelButton();
            HideToggleButtonIfValid();
        }

        private void SetForm(Form? form)
        {
            _form = form ?? throw new ArgumentNullException(nameof(form), "Form can`t be null");
        }

        private void HideToggleButtonIfValid()
        {
            _form!.Resize += (s, e) => InitFullscreenResize();
        }
        
        private void IsToggleButtonVisible(Control? toggleButton = null)
        {
            _toggleButton = toggleButton;
            if (_toggleButton is { IsDisposed: false, IsHandleCreated: true })
            {
                _toggleButton.Visible = false;
            }
        }
        private void InitSidebar()
        {
            SuspendLayout();
            BackColor = Color.FromArgb(22, 22, 22);
            BorderStyle = BorderStyle.None;
            Dock = DockStyle.Left;
            // Set sidebar size by default
            Width = 200;
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            ResumeLayout();
        }


        public void InitFullscreenResize()
        {
            var settingsItem = _items.Find(item => item.Label.Text == "Settings");

            if (settingsItem == null)
                return; 

            const int bottomMargin = 50;
            int labelY = _form!.ClientSize.Height - bottomMargin;

            settingsItem.Label.Location = new Point(
                settingsItem.Label.Location.X,
                labelY
            );

            settingsItem.Icon.Location = new Point(
                settingsItem.Icon.Location.X,
                labelY
            );
        }
        
        private void OnFavoriteClick()
        {
            MessageBox.Show(@"Favorite");
        }
        private void OnLanguageClick()
        {
            MessageBox.Show(@"Language");
        }
        private void OnContractClick()
        {
            MessageBox.Show(@"Contract");
        }
        private void OnSettingsClick()
        {
            MessageBox.Show(@"Settings");
        }
        private void OnMusicClick()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_form is TuneForge mainForm)
                {
                    mainForm.CurrentMusicPath = openFileDialog.FileName;
                }
            }

            if (_form is TuneForge form)
            {
                form.TakeArtistSongName(form.CurrentMusicPath); 
                form.UpdateAlbumArt(form.CurrentMusicPath); 
            }
        }
        private void InitItems()
        {
            // TODO : fix paths in future
            //AddItem("Profile",  "D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\sidebar\\profile.png",  120, OnProfileClick);
            AddItem("Favorite", "D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\sidebar\\favoriter.png", 180, OnFavoriteClick);
            AddItem("Language", "D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\sidebar\\language.png", 250, OnLanguageClick);
            //AddItem("Contact", "D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\sidebar\\contact.png",  320, OnContractClick);
            AddItem("Music","D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\sidebar\\music.png",  320, OnMusicClick);
            AddItem("Settings", "D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\sidebar\\settings.png", 400, OnSettingsClick);
        }
        

        private void AddItem(string text, string relativePath, int top , Action action)
        {
            string fullPath =  relativePath;
            var item = new SidebarItem(text, fullPath, top , action);
            item.AddTo(this);
            _items.Add(item);
        }
        private void InitCancelButton()
        {
            // TODO : fix paths in future
            const string path = "D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\sidebar\\exit2.png";
            if (!File.Exists(path))
            {
                MessageBox.Show("File not found: " + path);
                return;
            }
            _cancelIcon = new PictureBox
            {
                Image = Image.FromFile(path),
                Size = new Size(24, 24),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(160, 10),
                Cursor = Cursors.Hand
            };
            _cancelIcon.Click += (s, e) =>
            {
                if (_toggleButton != null)
                    _toggleButton.Visible = true;
                Parent?.Controls.Remove(this);
                Dispose();
                
            };
            Controls.Add(_cancelIcon);
        }
    }

    internal sealed class SidebarItem
    {
        public Label Label { get; }
        public PictureBox Icon { get; }
        public SidebarItem(string text, string imagePath, int top , Action action)
        {
            Icon = new PictureBox
            {
                Image = Image.FromFile(imagePath),
                Size = new Size(24, 24),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(5, top),
                Cursor = Cursors.Hand
            };

            Label = new Label
            {
                Text = text,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 18 , FontStyle.Regular),
                UseCompatibleTextRendering = true,
                Location = new Point(35, top),
                AutoSize = true,
                Cursor = Cursors.Hand

            };
            /*
             *  To in order to give the icon and button functionality
             */
            Icon.Click += (s, e) => action();
            Label.Click += (s, e) => action();
        }
        public void AddTo(Control parent)
        {
            if (Icon.Parent != null && !Icon.IsDisposed)
                Icon.Parent.Controls.Remove(Icon);
    
            if (Label.Parent != null && !Label.IsDisposed)
                Label.Parent.Controls.Remove(Label);
    
            if (!parent.Controls.Contains(Icon))
                parent.Controls.Add(Icon);

            if (!parent.Controls.Contains(Label))
                parent.Controls.Add(Label);
        }
    }
}
