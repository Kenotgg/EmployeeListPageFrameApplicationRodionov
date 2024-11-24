using System.Windows;
using System.Windows.Navigation;

namespace EmployeeListPageFrameApplicationRodionov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OpenMainPage(null, null);
        }
        public void OpenMainPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("HomePage.xaml", UriKind.Relative);
        }
        private void OpenEmployeeListPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("EmployeeListPage.xaml", UriKind.Relative);
        }
        public void OpenEmployeeEditPage()
        {
            MainFrame.Source = new Uri("EmployeeEditPage.xaml", UriKind.Relative);
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }


}