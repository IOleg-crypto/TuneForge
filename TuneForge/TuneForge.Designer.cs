namespace TuneForge;

partial class TuneForge
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TuneForge));
        OpenSideBar = new ReaLTaiizor.Controls.MetroButton();
        metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
        labelProgram = new System.Windows.Forms.Label();
        musicBar = new System.Windows.Forms.Panel();
        previousSeek = new System.Windows.Forms.PictureBox();
        nextSeek = new System.Windows.Forms.PictureBox();
        playBox = new System.Windows.Forms.PictureBox();
        OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
        endMusicLabel = new System.Windows.Forms.Label();
        startMusicLabel = new System.Windows.Forms.Label();
        MusicTrackBar = new ReaLTaiizor.Controls.MetroTrackBar();
        StatusVolumeSound = new System.Windows.Forms.PictureBox();
        MusicLogo = new System.Windows.Forms.PictureBox();
        nameSong = new System.Windows.Forms.Label();
        nameArtist = new System.Windows.Forms.Label();
        selectFavoriteSong = new System.Windows.Forms.PictureBox();
        Shuffle = new System.Windows.Forms.PictureBox();
        repeatPlayList = new System.Windows.Forms.PictureBox();
        ForgePanel = new System.Windows.Forms.Panel();
        musicBar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)previousSeek).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nextSeek).BeginInit();
        ((System.ComponentModel.ISupportInitialize)playBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)StatusVolumeSound).BeginInit();
        ((System.ComponentModel.ISupportInitialize)MusicLogo).BeginInit();
        ((System.ComponentModel.ISupportInitialize)selectFavoriteSong).BeginInit();
        ((System.ComponentModel.ISupportInitialize)Shuffle).BeginInit();
        ((System.ComponentModel.ISupportInitialize)repeatPlayList).BeginInit();
        ForgePanel.SuspendLayout();
        SuspendLayout();
        // 
        // OpenSideBar
        // 
        OpenSideBar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
        OpenSideBar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
        OpenSideBar.DisabledForeColor = System.Drawing.Color.Gray;
        OpenSideBar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        OpenSideBar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
        OpenSideBar.HoverColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
        OpenSideBar.HoverTextColor = System.Drawing.Color.DimGray;
        OpenSideBar.IsDerivedStyle = false;
        OpenSideBar.Location = new System.Drawing.Point(10, 12);
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
        OpenSideBar.Text = "≡";
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
        metroLabel1.ThemeAuthor = "Taiizor";
        metroLabel1.ThemeName = "MetroLight";
        metroLabel1.Visible = false;
        // 
        // labelProgram
        // 
        labelProgram.BackColor = System.Drawing.Color.Black;
        labelProgram.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        labelProgram.ForeColor = System.Drawing.Color.Transparent;
        labelProgram.Location = new System.Drawing.Point(782, 12);
        labelProgram.Name = "labelProgram";
        labelProgram.Size = new System.Drawing.Size(123, 37);
        labelProgram.TabIndex = 2;
        labelProgram.Text = "TuneForge";
        // 
        // musicBar
        // 
        musicBar.AutoSize = true;
        musicBar.Controls.Add(previousSeek);
        musicBar.Controls.Add(nextSeek);
        musicBar.Controls.Add(playBox);
        musicBar.Location = new System.Drawing.Point(265, 493);
        musicBar.Name = "musicBar";
        musicBar.Size = new System.Drawing.Size(406, 93);
        musicBar.TabIndex = 3;
        // 
        // previousSeek
        // 
        previousSeek.Image = ((System.Drawing.Image)resources.GetObject("previousSeek.Image"));
        previousSeek.Location = new System.Drawing.Point(36, 3);
        previousSeek.Name = "previousSeek";
        previousSeek.Size = new System.Drawing.Size(70, 87);
        previousSeek.TabIndex = 2;
        previousSeek.TabStop = false;
        previousSeek.Click += startMusic;
        // 
        // nextSeek
        // 
        nextSeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        nextSeek.Image = ((System.Drawing.Image)resources.GetObject("nextSeek.Image"));
        nextSeek.Location = new System.Drawing.Point(260, 3);
        nextSeek.Name = "nextSeek";
        nextSeek.Size = new System.Drawing.Size(127, 87);
        nextSeek.TabIndex = 1;
        nextSeek.TabStop = false;
        nextSeek.Click += endMusic;
        // 
        // playBox
        // 
        playBox.Image = ((System.Drawing.Image)resources.GetObject("playBox.Image"));
        playBox.Location = new System.Drawing.Point(140, 3);
        playBox.Name = "playBox";
        playBox.Size = new System.Drawing.Size(126, 87);
        playBox.TabIndex = 0;
        playBox.TabStop = false;
        playBox.Click += OnClickMusic;
        // 
        // endMusicLabel
        // 
        endMusicLabel.BackColor = System.Drawing.Color.Transparent;
        endMusicLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        endMusicLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
        endMusicLabel.Location = new System.Drawing.Point(764, 423);
        endMusicLabel.Name = "endMusicLabel";
        endMusicLabel.Size = new System.Drawing.Size(72, 30);
        endMusicLabel.TabIndex = 8;
        // 
        // startMusicLabel
        // 
        startMusicLabel.BackColor = System.Drawing.Color.Transparent;
        startMusicLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        startMusicLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
        startMusicLabel.Location = new System.Drawing.Point(119, 425);
        startMusicLabel.Name = "startMusicLabel";
        startMusicLabel.Size = new System.Drawing.Size(68, 28);
        startMusicLabel.TabIndex = 7;
        // 
        // MusicTrackBar
        // 
        MusicTrackBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)((byte)205)), ((int)((byte)205)), ((int)((byte)205)));
        MusicTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
        MusicTrackBar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)((byte)235)), ((int)((byte)235)), ((int)((byte)235)));
        MusicTrackBar.DisabledBorderColor = System.Drawing.Color.Empty;
        MusicTrackBar.DisabledHandlerColor = System.Drawing.Color.FromArgb(((int)((byte)196)), ((int)((byte)196)), ((int)((byte)196)));
        MusicTrackBar.DisabledValueColor = System.Drawing.Color.FromArgb(((int)((byte)205)), ((int)((byte)205)), ((int)((byte)205)));
        MusicTrackBar.HandlerColor = System.Drawing.Color.FromArgb(((int)((byte)180)), ((int)((byte)180)), ((int)((byte)180)));
        MusicTrackBar.IsDerivedStyle = true;
        MusicTrackBar.Location = new System.Drawing.Point(132, 404);
        MusicTrackBar.Maximum = 100;
        MusicTrackBar.Minimum = 0;
        MusicTrackBar.Name = "MusicTrackBar";
        MusicTrackBar.Size = new System.Drawing.Size(670, 16);
        MusicTrackBar.Style = ReaLTaiizor.Enum.Metro.Style.Light;
        MusicTrackBar.StyleManager = null;
        MusicTrackBar.TabIndex = 4;
        MusicTrackBar.ThemeAuthor = "Taiizor";
        MusicTrackBar.ThemeName = "MetroLight";
        MusicTrackBar.Value = 0;
        MusicTrackBar.ValueColor = System.Drawing.Color.FromArgb(((int)((byte)65)), ((int)((byte)177)), ((int)((byte)225)));
        // 
        // StatusVolumeSound
        // 
        StatusVolumeSound.BackColor = System.Drawing.Color.Transparent;
        StatusVolumeSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        StatusVolumeSound.Image = ((System.Drawing.Image)resources.GetObject("StatusVolumeSound.Image"));
        StatusVolumeSound.Location = new System.Drawing.Point(119, 360);
        StatusVolumeSound.Name = "StatusVolumeSound";
        StatusVolumeSound.Size = new System.Drawing.Size(39, 38);
        StatusVolumeSound.TabIndex = 9;
        StatusVolumeSound.TabStop = false;
        StatusVolumeSound.Click += StatusVolumeSound_Click;
        // 
        // MusicLogo
        // 
        MusicLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        MusicLogo.BackColor = System.Drawing.Color.Transparent;
        MusicLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        MusicLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        MusicLogo.Location = new System.Drawing.Point(234, 37);
        MusicLogo.Name = "MusicLogo";
        MusicLogo.Size = new System.Drawing.Size(470, 255);
        MusicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        MusicLogo.TabIndex = 10;
        MusicLogo.TabStop = false;
        // 
        // nameSong
        // 
        nameSong.AutoEllipsis = true;
        nameSong.BackColor = System.Drawing.Color.Transparent;
        nameSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        nameSong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        nameSong.ForeColor = System.Drawing.SystemColors.ButtonFace;
        nameSong.Location = new System.Drawing.Point(246, 295);
        nameSong.Name = "nameSong";
        nameSong.Size = new System.Drawing.Size(425, 32);
        nameSong.TabIndex = 11;
        nameSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        nameSong.Visible = false;
        // 
        // nameArtist
        // 
        nameArtist.BackColor = System.Drawing.Color.Transparent;
        nameArtist.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        nameArtist.ForeColor = System.Drawing.SystemColors.ButtonFace;
        nameArtist.Location = new System.Drawing.Point(352, 344);
        nameArtist.Name = "nameArtist";
        nameArtist.Size = new System.Drawing.Size(226, 27);
        nameArtist.TabIndex = 12;
        nameArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        nameArtist.Visible = false;
        // 
        // selectFavoriteSong
        // 
        selectFavoriteSong.Image = ((System.Drawing.Image)resources.GetObject("selectFavoriteSong.Image"));
        selectFavoriteSong.Location = new System.Drawing.Point(724, 360);
        selectFavoriteSong.Name = "selectFavoriteSong";
        selectFavoriteSong.Size = new System.Drawing.Size(33, 38);
        selectFavoriteSong.TabIndex = 13;
        selectFavoriteSong.TabStop = false;
        selectFavoriteSong.Click += selectFavoriteSongToPlayList;
        // 
        // Shuffle
        // 
        Shuffle.Image = ((System.Drawing.Image)resources.GetObject("Shuffle.Image"));
        Shuffle.Location = new System.Drawing.Point(782, 360);
        Shuffle.Name = "Shuffle";
        Shuffle.Size = new System.Drawing.Size(35, 33);
        Shuffle.TabIndex = 14;
        Shuffle.TabStop = false;
        // 
        // repeatPlayList
        // 
        repeatPlayList.Image = ((System.Drawing.Image)resources.GetObject("repeatPlayList.Image"));
        repeatPlayList.Location = new System.Drawing.Point(835, 360);
        repeatPlayList.Name = "repeatPlayList";
        repeatPlayList.Size = new System.Drawing.Size(37, 36);
        repeatPlayList.TabIndex = 15;
        repeatPlayList.TabStop = false;
        repeatPlayList.Click += repeatSong;
        // 
        // ForgePanel
        // 
        ForgePanel.Controls.Add(repeatPlayList);
        ForgePanel.Controls.Add(Shuffle);
        ForgePanel.Controls.Add(selectFavoriteSong);
        ForgePanel.Controls.Add(nameArtist);
        ForgePanel.Controls.Add(nameSong);
        ForgePanel.Controls.Add(MusicLogo);
        ForgePanel.Controls.Add(StatusVolumeSound);
        ForgePanel.Controls.Add(startMusicLabel);
        ForgePanel.Controls.Add(endMusicLabel);
        ForgePanel.Controls.Add(MusicTrackBar);
        ForgePanel.Controls.Add(musicBar);
        ForgePanel.Controls.Add(labelProgram);
        ForgePanel.Controls.Add(OpenSideBar);
        ForgePanel.Location = new System.Drawing.Point(2, 0);
        ForgePanel.Name = "ForgePanel";
        ForgePanel.Size = new System.Drawing.Size(913, 630);
        ForgePanel.TabIndex = 16;
        ForgePanel.ControlRemoved += ForgePanelControlRemoved;
        // 
        // TuneForge
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Black;
        ClientSize = new System.Drawing.Size(910, 610);
        Controls.Add(ForgePanel);
        Controls.Add(metroLabel1);
        DoubleBuffered = true;
        ForeColor = System.Drawing.Color.Transparent;
        Location = new System.Drawing.Point(19, 19);
        Load += TuneForgeLoad;
        ResizeEnd += TuneForge_ResizeEnd;
        ControlRemoved += TuneForge_ControlRemoved;
        musicBar.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)previousSeek).EndInit();
        ((System.ComponentModel.ISupportInitialize)nextSeek).EndInit();
        ((System.ComponentModel.ISupportInitialize)playBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)StatusVolumeSound).EndInit();
        ((System.ComponentModel.ISupportInitialize)MusicLogo).EndInit();
        ((System.ComponentModel.ISupportInitialize)selectFavoriteSong).EndInit();
        ((System.ComponentModel.ISupportInitialize)Shuffle).EndInit();
        ((System.ComponentModel.ISupportInitialize)repeatPlayList).EndInit();
        ForgePanel.ResumeLayout(false);
        ForgePanel.PerformLayout();
        ResumeLayout(false);
    }

    public System.Windows.Forms.Panel ForgePanel;

    private System.Windows.Forms.PictureBox repeatPlayList;

    private System.Windows.Forms.PictureBox Shuffle;

    private System.Windows.Forms.PictureBox selectFavoriteSong;

    private System.Windows.Forms.Label nameSong;
    private System.Windows.Forms.Label nameArtist;

    private System.Windows.Forms.PictureBox MusicLogo;

    private System.Windows.Forms.PictureBox StatusVolumeSound;

    private System.Windows.Forms.Label endMusicLabel;
    private System.Windows.Forms.Label startMusicLabel;
    private ReaLTaiizor.Controls.MetroTrackBar MusicTrackBar;


    private System.Windows.Forms.OpenFileDialog OpenFileDialog;

    private System.Windows.Forms.PictureBox previousSeek;

    private System.Windows.Forms.PictureBox nextSeek;

    private System.Windows.Forms.Panel musicBar;

    private System.Windows.Forms.PictureBox playBox;

    private System.Windows.Forms.Label labelProgram;

    private ReaLTaiizor.Controls.MetroLabel metroLabel1;

    private ReaLTaiizor.Controls.MetroButton OpenSideBar;
    

    #endregion
}