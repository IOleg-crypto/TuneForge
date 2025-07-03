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
            selectFavoriteSong.Anchor = AnchorStyles.Bottom;
            repeatPlayList.Anchor = AnchorStyles.Bottom;
            Shuffle.Anchor = AnchorStyles.Bottom;
        }
        private void TuneForge_ResizeBegin(object sender, EventArgs e)
        {
            labelProgram.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            musicBar.Anchor = AnchorStyles.Bottom;
            MusicTrackBar.Anchor = AnchorStyles.Bottom;
            startMusicLabel.Anchor = AnchorStyles.Bottom;
            endMusicLabel.Anchor = AnchorStyles.Bottom;
            StatusVolumeSound.Anchor = AnchorStyles.Bottom;
            selectFavoriteSong.Anchor = AnchorStyles.Bottom;
            repeatPlayList.Anchor = AnchorStyles.Bottom;
            Shuffle.Anchor = AnchorStyles.Bottom;
        }

        private void TuneForge_ResizeEnd(object sender, EventArgs e)
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
            selectFavoriteSong.Dock = DockStyle.None;
            selectFavoriteSong.Anchor = AnchorStyles.Bottom;
            repeatPlayList.Dock = DockStyle.None;
            repeatPlayList.Anchor = AnchorStyles.Bottom;
            Shuffle.Dock = DockStyle.None;
            Shuffle.Anchor = AnchorStyles.Bottom;
            
            
        }
        private void TuneForge_ControlRemoved(object sender, ControlEventArgs e)
        {
            Control[] controlsToShift =
            [
                musicBar, startMusicLabel, endMusicLabel, MusicTrackBar,
                StatusVolumeSound, MusicLogo, nameSong, nameArtist,
                Shuffle, selectFavoriteSong, repeatPlayList
            ];

            foreach (var control in controlsToShift)
            {
                control.Location = new Point(control.Location.X - 80, control.Location.Y);
            }
        }
        
    }
}