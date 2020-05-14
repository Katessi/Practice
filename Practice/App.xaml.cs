using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Practice
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            try
            {
                MainWindow = new Windows.MainWindow();
                MainWindow.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {

        }
    }
}
