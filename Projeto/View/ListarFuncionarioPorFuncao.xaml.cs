using Controllers;
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
    /// Interaction logic for ListarFuncionarioPorFuncao.xaml
    /// </summary>
    public partial class ListarFuncionarioPorFuncao : Window
    {
        public ListarFuncionarioPorFuncao()
        {
            InitializeComponent();
        }       

        private void btnBuscarFuncao(object sender, RoutedEventArgs e)
        {
            ControllerFuncionario controllerFuncionario = new ControllerFuncionario();
            dgFuncionarios.ItemsSource = controllerFuncionario.ListarPorFuncao(Convert.ToString(txtFuncao.Text));
        }
    }
}
