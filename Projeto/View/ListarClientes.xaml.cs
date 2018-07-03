using Controllers;
using Models;
using System.Windows;
using System.Windows.Controls;

namespace View
{
    /// <summary>
    /// Interaction logic for ListarClientes.xaml
    /// </summary>
    public partial class ListarClientes : Window
    {
        public ListarClientes()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ControllerCliente controllerCliente = new ControllerCliente();
            dgCliente.ItemsSource = controllerCliente.ListTodosClientes();
        }

        private void dgCliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

          Cliente cli = (Cliente)dg.Items[dg.SelectedIndex];
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
