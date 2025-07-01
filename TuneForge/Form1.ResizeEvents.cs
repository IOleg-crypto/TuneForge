namespace TuneForge
{
    public partial class Form1
    {
        private int _originalMusicBarHeight;
        private int _originalstartMusicLabelHeight;
        private int _originalendMusicLabelHeight;
        private int _originalMusicTrackBarHeight;

        private void LayoutMusicComponents()
        {
            labelProgram.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            musicBar.Anchor = AnchorStyles.Bottom;
            _originalstartMusicLabelHeight = startMusicLabel.Height;
            _originalendMusicLabelHeight = endMusicLabel.Height;
            _originalMusicTrackBarHeight = MusicTrackBar.Height;
            _originalMusicBarHeight = musicBar.Height;
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            labelProgram.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            musicBar.Anchor = AnchorStyles.Bottom;
            _originalstartMusicLabelHeight = startMusicLabel.Height;
            _originalendMusicLabelHeight = endMusicLabel.Height;
            _originalMusicTrackBarHeight = MusicTrackBar.Height;
            _originalMusicBarHeight = musicBar.Height;
            // Increase size
            musicBar.Height += 20; 
            musicBar.Width+= 20;
            startMusicLabel.Height += 20;
            startMusicLabel.Width += 20;
            endMusicLabel.Height += 20;
            endMusicLabel.Width += 20;
            MusicTrackBar.Height += 20;
            
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            labelProgram.Dock = DockStyle.None;
            labelProgram.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // Come back to original size
            musicBar.Height = _originalMusicBarHeight;
            musicBar.Width = _originalMusicBarHeight;
            startMusicLabel.Height = _originalstartMusicLabelHeight;
            startMusicLabel.Width = _originalstartMusicLabelHeight;
            endMusicLabel.Height = _originalendMusicLabelHeight;
            endMusicLabel.Width = _originalendMusicLabelHeight;
            MusicTrackBar.Height = _originalMusicTrackBarHeight;
        }
        private void Form1_ControlRemoved(object sender, ControlEventArgs e)
        {
            musicBar.Location = new Point(musicBar.Location.X - 80, musicBar.Location.Y);
            startMusicLabel.Location = new Point(startMusicLabel.Location.X - 80, startMusicLabel.Location.Y);
            endMusicLabel.Location = new Point(endMusicLabel.Location.X - 80, endMusicLabel.Location.Y);
            MusicTrackBar.Location = new Point(MusicTrackBar.Location.X - 80, MusicTrackBar.Location.Y);
        }

    }
}