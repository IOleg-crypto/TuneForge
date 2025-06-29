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
        parrotSplashScreen1 = new ReaLTaiizor.Controls.ParrotSplashScreen();
        SuspendLayout();
        // 
        // parrotSplashScreen1
        // 
        parrotSplashScreen1.AllowDragging = true;
        parrotSplashScreen1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)30)), ((int)((byte)30)));
        parrotSplashScreen1.BottomText = "ReaLTaizor Special Edition";
        parrotSplashScreen1.BottomTextColor = System.Drawing.Color.White;
        parrotSplashScreen1.BottomTextLocation = new System.Drawing.Point(51, 125);
        parrotSplashScreen1.BottomTextSize = 16;
        parrotSplashScreen1.EllipseCornerRadius = 15;
        parrotSplashScreen1.IsEllipse = false;
        parrotSplashScreen1.LoadedColor = System.Drawing.Color.DodgerBlue;
        parrotSplashScreen1.ProgressBarBorder = false;
        parrotSplashScreen1.ProgressBarLocation = new System.Drawing.Point(0, 224);
        parrotSplashScreen1.ProgressBarStyle = ReaLTaiizor.Controls.ParrotFlatProgressBar.Style.Material;
        parrotSplashScreen1.SecondsDisplayed = 3000;
        parrotSplashScreen1.ShowProgressBar = true;
        parrotSplashScreen1.SplashIcon = ((System.Drawing.Icon)resources.GetObject("parrotSplashScreen1.SplashIcon"));
        parrotSplashScreen1.SplashSize = new System.Drawing.Size(450, 280);
        parrotSplashScreen1.TopText = "Visual Studio";
        parrotSplashScreen1.TopTextColor = System.Drawing.Color.White;
        parrotSplashScreen1.TopTextLocation = new System.Drawing.Point(0, 70);
        parrotSplashScreen1.TopTextSize = 36;
        parrotSplashScreen1.UnloadedColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)30)), ((int)((byte)30)));
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(800, 450);
        ControlBox = false;
        Text = "TuneForge";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    private ReaLTaiizor.Controls.ParrotSplashScreen parrotSplashScreen1;

    #endregion
}