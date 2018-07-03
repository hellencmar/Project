using Controllers;
using Models;
using System.Windows;
using System.Windows.Controls;

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

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
