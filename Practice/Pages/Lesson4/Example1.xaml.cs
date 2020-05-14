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
                Message.FontSize = ((Slider)sender).Value;
        }
    }
}
