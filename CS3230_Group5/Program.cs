using System;
using System.Windows.Forms;
using CS3230_Group5.View;

namespace CS3230_Group5
{
    /// <summary>
    /// Provides the main entry point for the CS3230_Group5 application.
    /// Initializes application configuration and starts the login page.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Starts the application, initializes Windows Forms configuration,
        /// and opens the login page.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LogInPage());
        }
    }
}