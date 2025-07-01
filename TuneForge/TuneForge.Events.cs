namespace TuneForge
{ 
    public partial class TuneForge
    {
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            audioFile!.Dispose();
            audioFile = null;
            outputDevice?.Dispose();
            outputDevice = null;
        }
    }
}