namespace TuneForge
{
    public partial class TuneForge
    {
        private void LayoutMusicComponents()
        {
            labelProgram.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            musicBar.Anchor = AnchorStyles.Bottom;
            MusicTrackBar.Anchor = AnchorStyles.Bottom;
            startMusicLabel.Anchor = AnchorStyles.Bottom;
            endMusicLabel.Anchor = AnchorStyles.Bottom;
            StatusVolumeSound.Anchor = AnchorStyles.Bottom;
            MusicLogo.Anchor = AnchorStyles.Bottom;
            nameSong.Anchor = AnchorStyles.Bottom;
            nameArtist.Anchor = AnchorStyles.Bottom;
            
        }
        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            labelProgram.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            musicBar.Anchor = AnchorStyles.Bottom;
            MusicTrackBar.Anchor = AnchorStyles.Bottom;
            startMusicLabel.Anchor = AnchorStyles.Bottom;
            endMusicLabel.Anchor = AnchorStyles.Bottom;
            StatusVolumeSound.Anchor = AnchorStyles.Bottom;
            
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            labelProgram.Dock = DockStyle.None;
            labelProgram.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            musicBar.Dock = DockStyle.None;
            musicBar.Anchor = AnchorStyles.Bottom;
            MusicTrackBar.Dock = DockStyle.None;
            MusicTrackBar.Anchor = AnchorStyles.Bottom;
            startMusicLabel.Dock = DockStyle.None;
            startMusicLabel.Anchor = AnchorStyles.Bottom;
            endMusicLabel.Dock = DockStyle.None;
            endMusicLabel.Anchor = AnchorStyles.Bottom;
            StatusVolumeSound.Dock = DockStyle.None;
            StatusVolumeSound.Anchor = AnchorStyles.Bottom;
            
            
        }
        private void Form1_ControlRemoved(object sender, ControlEventArgs e)
        {
            musicBar.Location = new Point(musicBar.Location.X - 80, musicBar.Location.Y);
            startMusicLabel.Location = new Point(startMusicLabel.Location.X - 80, startMusicLabel.Location.Y);
            endMusicLabel.Location = new Point(endMusicLabel.Location.X - 80, endMusicLabel.Location.Y);
            MusicTrackBar.Location = new Point(MusicTrackBar.Location.X - 80, MusicTrackBar.Location.Y);
            StatusVolumeSound.Location = new Point(StatusVolumeSound.Location.X - 80, StatusVolumeSound.Location.Y);
            MusicLogo.Location = new Point(MusicLogo.Location.X - 80, MusicLogo.Location.Y);
            nameSong.Location = new Point(nameSong.Location.X - 80, nameSong.Location.Y);
            nameArtist.Location = new Point(nameArtist.Location.X - 80, nameArtist.Location.Y);
        }
    }
}