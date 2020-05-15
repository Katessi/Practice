using Microsoft.Win32;

using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Practice.Pages.Lesson5
{
    /// <summary>
    /// Interaction logic for FinalTask3.xaml
    /// </summary>
    public partial class FinalTask3 : Page
    {
        public FinalTask3()
        {
            InitializeComponent();
        }

        private void T1_GotFocus(object sender, RoutedEventArgs e)
        {
            //(sender as FrameworkElement).Style = (Style)Resources["ИМЯ_СТИЛЯ"]; 
            (sender as FrameworkElement).Style = (Style)Resources["s1"];
            t2.Style = (Style)Resources["s2"];
            t3.Style = (Style)Resources["s2"];
            t4.Style = (Style)Resources["s2"];
        }

        private void T2_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as FrameworkElement).Style = (Style)Resources["s1"];
            t1.Style = (Style)Resources["s2"];
            t3.Style = (Style)Resources["s2"];
            t4.Style = (Style)Resources["s2"];
        }

        private void T3_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as FrameworkElement).Style = (Style)Resources["s1"];
            t2.Style = (Style)Resources["s2"];
            t1.Style = (Style)Resources["s2"];
            t4.Style = (Style)Resources["s2"];
        }

        private void T4_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as FrameworkElement).Style = (Style)Resources["s1"];
            t1.Style = (Style)Resources["s2"];
            t3.Style = (Style)Resources["s2"];
            t2.Style = (Style)Resources["s2"];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Multiselect = false;
            OpenFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (OpenFileDialog.ShowDialog() == false)
            {
                return;
            }

            var file = File.ReadAllText(OpenFileDialog.FileName, Encoding.GetEncoding("Windows-1251"));
            t1.Text = t2.Text = t3.Text = t4.Text = file;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var SaveFileDialog = new SaveFileDialog();
            SaveFileDialog.AddExtension = true;
            SaveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (SaveFileDialog.ShowDialog() == false)
            {
                return;
            }

            if (t1.Style == (Style)Resources["s1"])
            {
                File.WriteAllText(SaveFileDialog.FileName, t1.Text, Encoding.GetEncoding("Windows-1251"));
            }

            if (t2.Style == (Style)Resources["s1"])
            {
                File.WriteAllText(SaveFileDialog.FileName, t2.Text, Encoding.GetEncoding("Windows-1251"));
            }

            if (t3.Style == (Style)Resources["s1"])
            {
                File.WriteAllText(SaveFileDialog.FileName, t3.Text, Encoding.GetEncoding("Windows-1251"));
            }

            if (t4.Style == (Style)Resources["s1"])
            {
                File.WriteAllText(SaveFileDialog.FileName, t4.Text, Encoding.GetEncoding("Windows-1251"));
            }
        }
    }
}
