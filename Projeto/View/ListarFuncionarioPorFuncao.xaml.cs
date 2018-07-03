using Controllers;
using System;
using System.Windows;

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

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
