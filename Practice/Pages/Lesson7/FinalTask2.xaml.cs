using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace Practice.Pages.Lesson7
{
    /// <summary>
    /// Interaction logic for FinalTask2.xaml
    /// </summary>
    public partial class FinalTask2 : Page
    {
        private ThicknessAnimation Animation = new ThicknessAnimation()
        {
            From = new Thickness(0, 0, 0, 0),
            To = new Thickness(5, 5, 5, 5),
            Duration = TimeSpan.FromMilliseconds(200)
        };

        public FinalTask2()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            e.Handled = true;
            var Random = new Random();
            var Button = sender as Button;
            Animation.From = new Thickness(Button.Margin.Left, Button.Margin.Top, Button.Margin.Right, Button.Margin.Bottom);

            double Left = Button.Margin.Left + Random.Next(-1, 1) * Random.Next(200, 300);
            double Top = Button.Margin.Top + Random.Next(-1, 1) * Random.Next(200, 300);
            double Right = Button.Margin.Right + Random.Next(-1, 1) * Random.Next(200, 300);
            double Bottom = Button.Margin.Bottom + Random.Next(-1, 1) * Random.Next(200, 300);

            Animation.To = new Thickness(Left, Top, Right, Bottom);
            Button.BeginAnimation(MarginProperty, Animation);
        }
    }
}
