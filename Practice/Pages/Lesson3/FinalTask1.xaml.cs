using Practice.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practice.Pages.Lesson3
{
    /// <summary>
    /// Interaction logic for FinalTask1.xaml
    /// </summary>
    public partial class FinalTask1 : Page
    {
        public FinalTask1()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cb = sender as ComboBox;
            if (cb.SelectedIndex == 0)
            {
                this.Background = Brushes.White;
            }
            else if (cb.SelectedIndex == 1)
            {
                this.Background = Brushes.Red;
            }
            else if (cb.SelectedIndex == 2)
            {
                this.Background = Brushes.Green;
            }
            else if (cb.SelectedIndex == 3)
            {
                this.Background = Brushes.Blue;
            }
            else
            {
                return;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            App.ShowPageInDialog(new AboutPage());
        }

        private void _ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            if (sender is Control)
            {
                e.Handled = true;
                status.Text = (sender as Control).ToolTip.ToString();
            }

            //if(sender is MenuItem)
            //{
            //    e.Handled = true;
            //    status.Text = (sender as MenuItem).ToolTip.ToString();
            //}
        }
    }
}
