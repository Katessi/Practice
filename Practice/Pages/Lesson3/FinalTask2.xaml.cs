using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Practice.Pages.Lesson3
{
    /// <summary>
    /// Interaction logic for FinalTask2.xaml
    /// </summary>
    public partial class FinalTask2 : Page
    {
        public FinalTask2()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;

            if (area == null)
            {
                return;
            }

            area.DefaultDrawingAttributes.Width = slider.Value;
            area.DefaultDrawingAttributes.Height = slider.Value;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cb = sender as ComboBox;

            if (area == null)
            {
                return;
            }

            if (cb.SelectedIndex == 0)
            {
                area.DefaultDrawingAttributes.Color = Colors.Black;
            }
            else if (cb.SelectedIndex == 1)
            {
                area.DefaultDrawingAttributes.Color = Colors.Red;
            }
            else if (cb.SelectedIndex == 2)
            {
                area.DefaultDrawingAttributes.Color = Colors.Green;
            }
            else if (cb.SelectedIndex == 3)
            {
                area.DefaultDrawingAttributes.Color = Colors.Blue;
            }
            else
            {
                return;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = sender as TextBox;
            if (string.IsNullOrEmpty(tb.Text))
            {
                return;
            }

            if (!double.TryParse(tb.Text, out double size))
            {
                return;
            }

            if (area == null)
            {
                return;
            }

            area.DefaultDrawingAttributes.Width = size;
            area.DefaultDrawingAttributes.Width = size;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            area.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            area.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }
    }
}
