namespace Threeday
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            //Application.Run(new Form2());
            //Application.Run(new focustnogo());
            //Application.Run(new lunbotu());
            //Application.Run(new location());
            //Application.Run(new iphone());
            //Application.Run(new jiaodiangaoliang());
            //Application.Run(new jiaodianlanjie());
            //Application.Run(new excle());
            Application.Run(new wasd());
        }
    }
}