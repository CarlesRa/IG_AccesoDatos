using System;
using System.Collections.Generic;
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
using WindowNewEmployee;

namespace WindowNewEmployee
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>

    using Empleados;
    public partial class Window1 : Window
    {
        private Employee employee;
        private string name;
        private string title;
        private bool wasRelected;
        private Party party;
        private WindowNewEmployee.MainWindow window;
        private int itemSelected;

        public  Window1(string name, string title, bool wasRelected, Party party, int itemSelected)
        {
            InitializeComponent();
            this.name = name;
            this.title = title;
            this.wasRelected = wasRelected;
            this.party = party;
            this.itemSelected = itemSelected;
        }

        private void btSi_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btNo_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.window = new MainWindow(name, title, wasRelected, party, itemSelected);
            window.Show();
        }

       
    }
}
