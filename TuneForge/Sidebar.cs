using System.Diagnostics;
using System.Drawing.Text;
using Panel = System.Windows.Forms.Panel;

namespace TuneForge
{
    public sealed class Sidebar : Panel
    {
        private List<SidebarItem> _items = new();
        private PictureBox _cancelIcon = null!;
        private readonly Control? _toggleButton;
        private readonly int _Width = 200;

        public Sidebar(Control? toggleButton = null)
        {
            _toggleButton = toggleButton;
            if (_toggleButton != null && !_toggleButton.IsDisposed && _toggleButton.IsHandleCreated)
                _toggleButton.Visible = false;
            
            InitSidebar();
            InitItems();
            InitCancelButton();
        }

        private void InitSidebar()
        {
            this.SuspendLayout();
            BackColor = Color.FromArgb(24, 21, 19);
            BorderStyle = BorderStyle.None;
            Dock = DockStyle.Left;
            
            Width = _Width;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.ResumeLayout();
        }
        
        private void OnProfileClick()
        {
            MessageBox.Show("Profile");
        }
        private void OnFavoriteClick()
        {
            MessageBox.Show("Favorite");
        }
        private void OnLanguageClick()
        {
            MessageBox.Show("Language");
        }
        private void OnContractClick()
        {
            MessageBox.Show("Contract");
        }
        private void OnSettingsClick()
        {
            MessageBox.Show("Settings");
        }
        
        private void OnMusicClick()
        {
            MessageBox.Show("Music");
        }
        
        private void InitItems()
        {
            // TODO : fix paths in future
            AddItem("Profile",  "D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\sidebar\\profile.png",  120, OnProfileClick);
            AddItem("Favorite", "D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\sidebar\\favoriter.png", 180, OnFavoriteClick);
            AddItem("Language", "D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\sidebar\\language.png", 250, OnLanguageClick);
            AddItem("Contract", "D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\sidebar\\contact.png",  320, OnContractClick);
            AddItem("Music","D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\sidebar\\music.png",  400, OnMusicClick);
            AddItem("Settings", "D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\sidebar\\settings.png", 550, OnSettingsClick);
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
            const string path = "D:\\gitnext\\csharpProject\\TuneForrge\\TuneForge\\assets\\sidebar\\cancel.png";
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
        private Label Label { get; }
        private PictureBox Icon { get; }
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
            /*
             *  To draw the text smoothly
             */
            Label.Paint += (s, e) =>
            {
                e.Graphics.Clear(Label.BackColor);
                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

                using var brush = new SolidBrush(Color.White);
                e.Graphics.DrawString(Label.Text, Label.Font, brush, new PointF(0, 0));
            };
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
