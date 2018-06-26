using Controllers;
using Models;
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

namespace View
{
    /// <summary>
    /// Interaction logic for ListarFuncionarios.xaml
    /// </summary>
    public partial class ListarFuncionarios : Window
    {
        public ListarFuncionarios()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ControllerFuncionario controllerFuncionario = new ControllerFuncionario();
            dgFuncionarios.ItemsSource = controllerFuncionario.ListTodosFuncionarios();
        }

        private void dgFuncionarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            Funcionario func = (Funcionario)dg.Items[dg.SelectedIndex];
        }
    }
}
