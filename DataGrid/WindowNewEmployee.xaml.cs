using Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace DataGrid
{
    /// <summary>
    /// Lógica de interacción para WindowNewEmployee.xaml
    /// </summary>
    public partial class WindowNewEmployee : Window
    {
        private Employee employee;
        private string name;
        private string title;
        private Party Afiliation;
        public bool itsOk;
        private bool isRelected;

        public WindowNewEmployee()
        {
            InitializeComponent();
        }

        private void btSaveEmployee_Click(object sender, RoutedEventArgs e)
        {
            itsOk = false;
            name = tbName.Text;
            title = tbTitle.Text;

            switch (cbPolitic.SelectedIndex)
            {
                case 0:
                    Afiliation = Party.Indepentent;
                    itsOk = true;
                    break;
                case 1:

                    Afiliation = Party.Federalist;
                    itsOk = true;
                    break;
                case 2:
                    Afiliation = Party.DemocratRepublican;
                    itsOk = true;
                    break;

            }            

            if (cbRelected.IsChecked.Value)
            {
                isRelected = true;
            }
            else
            {
                isRelected = false;
            }

            if(tbName.Text.Equals("") || tbTitle.Text.Equals(""))
            {
                itsOk = false;
            }
            this.Close();
        }

        public void OnWindowClosing(object sender, CancelEventArgs e)
        {
            if (itsOk == true)
            {
                employee = new Employee();
                employee.addEmployee(name, title, isRelected, Afiliation);
                MessageBox.Show("Empleado añadido con éxito!!!");
            }
            else
            {
                MessageBox.Show("Error al añadir...");
            }
        }
    }
}
