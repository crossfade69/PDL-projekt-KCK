namespace customforms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            loginForm loginscreen= new loginForm();
            Application.Run(loginscreen);

             if(loginscreen.IsLogged)
             {
                 Application.Run(new mainForm());
             }
            //Application.Run(new mainForm());
        }
    }
}