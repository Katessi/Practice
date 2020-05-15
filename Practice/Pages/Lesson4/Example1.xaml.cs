using System.Windows;
using System.Windows.Controls;

namespace Practice.Pages.Lesson4
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Message != null)
            {
                Message.FontSize = ((Slider)sender).Value;
            }
        }
    }
}
