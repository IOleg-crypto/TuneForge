namespace TuneForge;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        ApplicationConfiguration.Initialize();
        Application.SetCompatibleTextRenderingDefault(true);
        Application.Run(new Form1());
    }
}