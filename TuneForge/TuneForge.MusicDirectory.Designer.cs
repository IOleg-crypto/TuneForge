using System.ComponentModel;

namespace TuneForge;

partial class TuneForgeMusicDirectory
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new System.Windows.Forms.Button();
        openSideBarDirectory = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
        button1.Location = new System.Drawing.Point(65, 191);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(231, 70);
        button1.TabIndex = 0;
        button1.Text = "Text";
        button1.UseVisualStyleBackColor = false;
        button1.Click += BackToForm;
        // 
        // openSideBarDirectory
        // 
        openSideBarDirectory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        openSideBarDirectory.ForeColor = System.Drawing.SystemColors.ControlLight;
        openSideBarDirectory.Location = new System.Drawing.Point(0, 0);
        openSideBarDirectory.Name = "openSideBarDirectory";
        openSideBarDirectory.Size = new System.Drawing.Size(52, 34);
        openSideBarDirectory.TabIndex = 1;
        openSideBarDirectory.Text = "≡";
        openSideBarDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // TuneForgeMusicDirectory
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(openSideBarDirectory);
        Controls.Add(button1);
        Size = new System.Drawing.Size(966, 740);
        Load += MusicDirectoryLoad;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label openSideBarDirectory;

    private System.Windows.Forms.Button button1;

    #endregion
}