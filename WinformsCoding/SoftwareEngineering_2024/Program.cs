using SoftwareEngineering_2024.DB_connect;

namespace SoftwareEngineering_2024
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
            Application.Run(new LoginForm());
            //userDAL.TestDatabaseConnection();

        }
    }
}