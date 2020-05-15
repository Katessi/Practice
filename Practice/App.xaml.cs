using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Practice.Windows;

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
                Current.DispatcherUnhandledException += Current_DispatcherUnhandledException;
                MainWindow = new Windows.MainWindow();
                MainWindow.Show();
            }
            catch
            {

            }
        }

        private void Current_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            Debug.Fail(e.Exception.ToString());
            e.Handled = true;
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {

        }

        public static bool? ShowPageInDialog(Page page)
        {
            var MainWindow = new MainWindow(page);
            MainWindow.SizeToContent = SizeToContent.WidthAndHeight;
            MainWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            MainWindow.ResizeMode = ResizeMode.NoResize;
            return MainWindow.ShowDialog();
        }
    }
}
