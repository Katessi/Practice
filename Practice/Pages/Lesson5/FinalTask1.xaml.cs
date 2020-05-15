using System.Windows;
using System.Windows.Controls;

namespace Practice.Pages.Lesson5
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button is clicked");
        }
    }
}
