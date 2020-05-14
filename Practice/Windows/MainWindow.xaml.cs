using Practice.Models;
using Practice.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Practice.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.MainPage());
        }

        private void TasksListBox_Selected(object sender, RoutedEventArgs e)
        {
            var item = (sender as System.Windows.Controls.ListBox).SelectedItem as Models.MenuItem;

        }

        private void TasksDataGrid_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void TasksDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var SelectedTask = TasksDataGrid.SelectedItem as Models.MenuGroup;
            MessageBox.Show((TasksDataGrid.SelectedItem as Models.MenuGroup).Title);
            //if (SelectedTask == null)
            //    return;

            //if (MainFrame.NavigationService.Navigate(SelectedTask.))
            //{
            //    Debug.WriteLine("All good");
            //}
            //else
            //{
            //    Debug.Fail("So bad");
            //}
        }
    }
}
