using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace EmployeeListPageFrameApplicationRodionov
{
    /// <summary>
    /// Логика взаимодействия для EmployeeListPage.xaml
    /// </summary>

    public partial class EmployeeListPage : Page
    {
        MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
        public ObservableCollection<Employee> Employees { get; set; }
        public EmployeeListPage()
        {
            InitializeComponent();

          

            Employees = new ObservableCollection<Employee>()
            {
                new Employee { id = 1, firstName = "Иван", lastName = "Иванов", salary = 100000, position = "Джун Разработчик", phoneNumber = "89998887742", address = "Улица Акулова д 13" },
                new Employee { id = 2, firstName = "Олег", lastName = "Петров", salary = 153333, position = "Мидл Разработчик", phoneNumber = "89498887522", address = "Улица Епифанцева д 9" },
                
                // ... другие сотрудники
            };

        }
        //public void EmployeeListPage(object sender, RoutedEvent e)
        //{
        //    InitializeComponent();
        //    MainGrid.ItemsSource = Employees; // Привязка напрямую в коде
        //}
        public void EditEmployee(object sender, EventArgs e)
        {
            //MessageBox.Show("edit");
            mainWindow.MainFrame.Source = new Uri("EmployeeEditPage.xaml", UriKind.Relative);
            //В метод что в View Model
            //получаем того кто выделен
            //Выводим данные
        }
    }
}

   




            

    



        













    



