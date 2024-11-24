using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace EmployeeListPageFrameApplicationRodionov
{
    /// <summary>
    /// Логика взаимодействия для EmployeeEditPag.xaml
    /// </summary>
    public partial class EmployeeEditPage : Page
    {
        //private readonly MainWindow _mainWindow;
        private Employee employee;
        public EmployeeEditPage(Employee employee, MainWindow mainWindow)
        {
           // _mainWindow = mainWindow;
            InitializeComponent();
          
            //TextBoxName.Text = employee.firstName;
            //TextBoxPosition.Text = employee.position;
        }
        public EmployeeEditPage() 
        {
            InitializeComponent();
        }
        public void ApplyChanges(object sender, RoutedEventArgs e)
        {
            
            employee.firstName = TextBoxName.Text;
            employee.position = TextBoxPosition.Text;

            NavigationService.GoBack();

        }
    }
}
