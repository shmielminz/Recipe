using RecipeSystem;
namespace RecipeWinForms
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
            DbManager.SetConnectionString("Server=.\\MSSQLSERVER01;Database=RecipeDB;Trusted_Connection=True;");
            Application.Run(new frmSearch());
        }
    }
}