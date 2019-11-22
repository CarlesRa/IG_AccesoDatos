using System.Windows;
using System.Windows.Input;
using Empleados;

namespace DataGrid
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly RoutedCommand Command = new RoutedCommand();
        
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Employee.GetEmployees();
            EventManager.RegisterClassHandler(typeof(MainWindow),
            Mouse.MouseDownEvent, new MouseButtonEventHandler(OnTreeViewItemMouseDown), false);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowNewEmployee.MainWindow ventanaEmpleados = new WindowNewEmployee.MainWindow();
            ventanaEmpleados.Show();
        }

        private void miNewEmployee_Click(object sender, RoutedEventArgs e)
        {
            WindowNewEmployee.MainWindow ventanaEmpleados = new WindowNewEmployee.MainWindow();
            ventanaEmpleados.Show();
        }

        private void onExit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void OnTreeViewItemMouseDown(object sender, MouseButtonEventArgs e)
        {
            var treeViewitem = sender as MainWindow;
            if (e.RightButton == MouseButtonState.Pressed)
            {
                dataGrid.Columns[0].IsReadOnly = false;
                dataGrid.Columns[1].IsReadOnly = false;
                dataGrid.Columns[2].IsReadOnly = false;
                dataGrid.Columns[3].IsReadOnly = false;
            }
        }


    }
}
