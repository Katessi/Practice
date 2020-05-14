using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for Example1.xaml
    /// </summary>
    public partial class Example1 : Page
    {
        public Example1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка нажата");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Состояние кнопки: {(sender as ToggleButton).IsChecked}");
        }

        private void CheckBox_CloseAfterComplete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"IsChecked == {CheckBox_CloseAfterComplete.IsChecked}");
        }

        private void RadioButton_Boot_Click(object sender, RoutedEventArgs e)
        {
            if (RadioButton_Boot1.IsChecked == true)
            {
                MessageBox.Show(RadioButton_Boot1.Content.ToString());
            }
            else if (RadioButton_Boot2.IsChecked == true)
            {
                MessageBox.Show(RadioButton_Boot2.Content.ToString());
            }
            else if (RadioButton_Boot3.IsChecked == true)
            {
                MessageBox.Show(RadioButton_Boot3.Content.ToString());
            }
        }

        private void mi_open_Click(object sender, RoutedEventArgs e)
        {
            mi_open.Background = Brushes.LightGreen;
        }
    }
}
