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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowNewEmployee
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Employee employee;
        private string name;
        private string title;
        private Party afiliation;
        public bool itsOk;
        private bool isRelected;
        private int itemSelected;

        public MainWindow()
        {
            InitializeComponent();
            name = null;
            title = null;
        }

        public MainWindow(string name, string title, bool wasRelected, Party party, int itemSelected)
        {
            InitializeComponent();
            tbName.Text = name;
            tbTitle.Text = title;
            this.isRelected = wasRelected;
            this.afiliation = party;
            cbPolitic.SelectedItem = cbPolitic.Items.GetItemAt(itemSelected);
        }
        private void btSaveEmployee_Click(object sender, RoutedEventArgs e)
        {
            rellenarCampos();
            if (itsOk)
            {
                employee = new Employee();
                employee.addEmployee(name, title, isRelected, afiliation);
                MessageBox.Show("Empleado guardado con éxito!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Faltan Atributos a Rellenar");
            }

            
            
        }

        public void OnWindowClosing(object sender, CancelEventArgs e)
        {
            if (!itsOk)
            {
                if (!itsOk && name != null && title != null && cbPolitic.SelectedIndex == 0
                   || cbPolitic.SelectedIndex == 1 || cbPolitic.SelectedIndex == 2)
                {
                    rellenarCampos();
                    WindowNewEmployee.Window1 ventanaAlerta = new Window1(name, title, isRelected, afiliation,itemSelected);
                    ventanaAlerta.Show();
                }
            }
        }

        public void rellenarCampos()
        {
            itsOk = false;
            name = tbName.Text;
            title = tbTitle.Text;

            switch (cbPolitic.SelectedIndex)
            {
                case 0:
                    afiliation = Party.Indepentent;
                    itemSelected = 0;
                    itsOk = true;
                    break;
                case 1:
                    afiliation = Party.Federalist;
                    itemSelected = 1;
                    itsOk = true;
                    break;
                case 2:
                    afiliation = Party.DemocratRepublican;
                    itemSelected = 2;
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

            if (tbName.Text.Equals("") || tbTitle.Text.Equals(""))
            {
                itsOk = false;
            }
        }

    }
}

