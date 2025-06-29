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
        OpenSideBar = new ReaLTaiizor.Controls.MetroButton();
        metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
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
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Black;
        ClientSize = new System.Drawing.Size(984, 610);
        Controls.Add(metroLabel1);
        Controls.Add(OpenSideBar);
        Text = "TuneForge";
        ResumeLayout(false);
    }

    private ReaLTaiizor.Controls.MetroLabel metroLabel1;

    private ReaLTaiizor.Controls.MetroButton OpenSideBar;

    #endregion
}