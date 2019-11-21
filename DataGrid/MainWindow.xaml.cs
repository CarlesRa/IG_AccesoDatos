using System.Windows;
using Empleados;

namespace DataGrid
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Employee.GetEmployees();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowNewEmployee.MainWindow ventanaEmpleados = new WindowNewEmployee.MainWindow();
            ventanaEmpleados.Show();
        }
    }
}
