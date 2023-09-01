using TrackerLibrary;

namespace TrackerUI
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

            // initialize the database connection sql and text file 
            TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.TextFile);

            // initialize the database connection to sql 
            //TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.Sql);

            Application.Run(new CreateTournamentForm());//test
            //Application.Run(new CreateTeamForm());// test
            //pplication.Run(new CreatePrizeForm());// test
            //Application.Run(new TournamentDashboardForm());
        }
    }
}