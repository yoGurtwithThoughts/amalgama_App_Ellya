using amalgama_App.View.Pages;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static amalgama_App.Core.MyNavigation;

namespace amalgama_App
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CoreNavigate.NavigatorCore = MainFrame;
            MainFrame.Navigate(new StartPage());

        }
        private void Window_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
          
            this.WindowState = WindowState.Maximized; 
            this.ResizeMode = ResizeMode.NoResize;
        }
    }
}