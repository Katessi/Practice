using System.Windows;
using System.Windows.Controls;

namespace Practice.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //TODO: Показывать на главной странице все фреймы с заданием
            //WOW: Window.GetWindow(this) ля как можно
            //FrameList.ItemsSource = new MainWindow.MainWindowViewModel().Menu;
        }
    }
}
