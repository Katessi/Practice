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
using System.Windows.Controls;
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
            MainFrame.Navigate(new Pages.MainPage());
        }

        public MainWindow(Page PageToLoadInDialog)
        {
            InitializeComponent();

            TasksDataGrid.Visibility = Visibility.Collapsed;
            MainFrame.Navigate(PageToLoadInDialog);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void TasksDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (TasksDataGrid.SelectedItem is Models.MenuItem)
            {
                //Госпади как же много времени я портатил(((
                var SelectedTask = TasksDataGrid.SelectedItem as Models.MenuItem;

                object instance = Activator.CreateInstance(SelectedTask.TargetType);
                if (MainFrame.Navigate(instance))
                {
                }
                else
                {
                }
            }
        }
    }
}
