using System.Windows;
using System.Windows.Controls;

namespace Practice.Pages.Lesson5
{
    /// <summary>
    /// Interaction logic for Example5.xaml
    /// </summary>
    public partial class Example5 : Page
    {
        public Example5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button is clicked");
        }
    }
}
