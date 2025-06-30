namespace TuneForge;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        OpenSideBar = new ReaLTaiizor.Controls.MetroButton();
        metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
        labelProgram = new System.Windows.Forms.Label();
        musicBar = new System.Windows.Forms.Panel();
        pictureBox3 = new System.Windows.Forms.PictureBox();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        musicBar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // OpenSideBar
        // 
        OpenSideBar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
        OpenSideBar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
        OpenSideBar.DisabledForeColor = System.Drawing.Color.Gray;
        OpenSideBar.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        OpenSideBar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
        OpenSideBar.HoverColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
        OpenSideBar.HoverTextColor = System.Drawing.Color.DimGray;
        OpenSideBar.IsDerivedStyle = false;
        OpenSideBar.Location = new System.Drawing.Point(12, 12);
        OpenSideBar.Name = "OpenSideBar";
        OpenSideBar.NormalBorderColor = System.Drawing.Color.Transparent;
        OpenSideBar.NormalColor = System.Drawing.Color.Transparent;
        OpenSideBar.NormalTextColor = System.Drawing.Color.White;
        OpenSideBar.PressBorderColor = System.Drawing.Color.Transparent;
        OpenSideBar.PressColor = System.Drawing.Color.Transparent;
        OpenSideBar.PressTextColor = System.Drawing.Color.Transparent;
        OpenSideBar.Size = new System.Drawing.Size(50, 37);
        OpenSideBar.Style = ReaLTaiizor.Enum.Metro.Style.Light;
        OpenSideBar.StyleManager = null;
        OpenSideBar.TabIndex = 0;
        OpenSideBar.Text = "☰";
        OpenSideBar.ThemeAuthor = "Taiizor";
        OpenSideBar.ThemeName = "MetroLight";
        OpenSideBar.Click += openSideBar;
        // 
        // metroLabel1
        // 
        metroLabel1.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        metroLabel1.IsDerivedStyle = true;
        metroLabel1.Location = new System.Drawing.Point(856, -1);
        metroLabel1.Name = "metroLabel1";
        metroLabel1.Size = new System.Drawing.Size(127, 29);
        metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
        metroLabel1.StyleManager = null;
        metroLabel1.TabIndex = 1;
        metroLabel1.Text = "TuneForge";
        metroLabel1.ThemeAuthor = "Taiizor";
        metroLabel1.ThemeName = "MetroLight";
        // 
        // labelProgram
        // 
        labelProgram.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        labelProgram.ForeColor = System.Drawing.Color.WhiteSmoke;
        labelProgram.Location = new System.Drawing.Point(856, 12);
        labelProgram.Name = "labelProgram";
        labelProgram.Size = new System.Drawing.Size(123, 37);
        labelProgram.TabIndex = 2;
        labelProgram.Text = "TuneForge";
        // 
        // musicBar
        // 
        musicBar.Controls.Add(pictureBox3);
        musicBar.Controls.Add(pictureBox2);
        musicBar.Controls.Add(pictureBox1);
        musicBar.Location = new System.Drawing.Point(259, 495);
        musicBar.Name = "musicBar";
        musicBar.Size = new System.Drawing.Size(425, 90);
        musicBar.TabIndex = 3;
        // 
        // pictureBox3
        // 
        pictureBox3.Image = ((System.Drawing.Image)resources.GetObject("pictureBox3.Image"));
        pictureBox3.Location = new System.Drawing.Point(46, 3);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new System.Drawing.Size(70, 87);
        pictureBox3.TabIndex = 2;
        pictureBox3.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = ((System.Drawing.Image)resources.GetObject("pictureBox2.Image"));
        pictureBox2.Location = new System.Drawing.Point(252, 3);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(132, 84);
        pictureBox2.TabIndex = 1;
        pictureBox2.TabStop = false;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(139, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(126, 87);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Black;
        ClientSize = new System.Drawing.Size(984, 610);
        Controls.Add(musicBar);
        Controls.Add(labelProgram);
        Controls.Add(metroLabel1);
        Controls.Add(OpenSideBar);
        Text = "TuneForge";
        Load += Form1_Load;
        ResizeBegin += Form1_ResizeBegin;
        ResizeEnd += Form1_ResizeEnd;
        ControlRemoved += Form1_ControlRemoved;
        musicBar.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.PictureBox pictureBox3;

    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.Panel musicBar;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Label labelProgram;

    private ReaLTaiizor.Controls.MetroLabel metroLabel1;

    private ReaLTaiizor.Controls.MetroButton OpenSideBar;

    #endregion
}