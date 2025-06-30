namespace TuneForge
{
    public partial class Form1
    {
        private int _originalMusicBarHeight;

        private void LayoutMusicComponents()
        {
            labelProgram.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            musicBar.Anchor = AnchorStyles.Bottom;
            _originalMusicBarHeight = musicBar.Height;
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            labelProgram.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            musicBar.Anchor = AnchorStyles.Bottom;
            
            _originalMusicBarHeight = musicBar.Height;
            // Increase size
            musicBar.Height += 20; 
            musicBar.Width+= 20;
            
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            labelProgram.Dock = DockStyle.None;
            labelProgram.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // Come back to original size
            musicBar.Height = _originalMusicBarHeight;
        }
    }
}