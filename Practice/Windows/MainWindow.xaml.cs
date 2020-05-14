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

            LeftPanel.Visibility = Visibility.Collapsed;
            MainFrame.Navigate(PageToLoadInDialog);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void _SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var _ = sender as ListBox;
            if (_.SelectedItem == null) return;

            if (_.SelectedItem is Models.MenuItem)
            {
                var SelectedTask = _.SelectedItem as Models.MenuItem;

                //Госпади как же много времени я портатил чтобы показать страницу по ее типу(((
                object instance = Activator.CreateInstance(SelectedTask.TargetType);
                MainFrame.Navigate(instance);
            }

            _.SelectedItem = null;
            e.Handled = true;
        }


        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).IsChecked == true)
            {
                //TODO: Немного изменить модельку чтобы тут работало
                var MainWindowViewModel = new MainWindowViewModel();
                //MainWindowViewModel.Menu = MainWindowViewModel.Menu.Where(x => x.MenuItems.Select(y => y.Title.));
                //Возможно нужно переписать на linq
                var newMenu = new List<MenuGroup>();
                foreach (var menuGroup in MainWindowViewModel.Menu)
                {
                    var newGroup = new MenuGroup();
                    foreach (var menuItem in menuGroup.MenuItems)
                    {
                        if (menuItem.Title.Contains("Задание"))
                        {
                            newGroup.MenuItems.Add(menuItem);
                        }
                    }
                    newMenu.Add(newGroup);
                }
                MainWindowViewModel.Menu = newMenu;
            }
        }
    }
}
