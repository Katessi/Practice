using System.Windows.Controls;

namespace Practice.Pages.Lesson6
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

        private void _TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text) || !string.IsNullOrEmpty(TextBox2.Text))
            {
                ButtonClose.IsEnabled = false;
            }
            else
            {
                ButtonClose.IsEnabled = true;
            }
        }
    }
}
