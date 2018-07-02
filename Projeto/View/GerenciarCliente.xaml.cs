using Controllers;
using Models;
using System;
using System.Windows;
using System.Windows.Input;

namespace View
{
    /// <summary>
    /// Interaction logic for EditarCliente.xaml
    /// </summary>
    public partial class GerenciarCliente : Window
    {
        Cliente cliente = new Cliente();
        ControllerCliente controllerCliente = new ControllerCliente();

        public GerenciarCliente()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {          
            dgDadosCliente.ItemsSource = controllerCliente.ListTodosClientes();
        }

        private void dgDadosCliente_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {            
                if (dgDadosCliente.SelectedIndex >= 0)
                {
                    cliente = (Cliente)dgDadosCliente.SelectedItem;
                    txtID.Text = (Convert.ToString(cliente.ClienteID)); //perguntar para o professor
                    txtNome.Text = cliente.Nome;
                    txtCPF.Text = cliente.CPF;
                    txtEmail.Text = cliente.Email;
                    txtTelefone.Text = cliente.Telefone;

                }
        }

        private void btn_Editar(object sender, RoutedEventArgs e)
        {
            try
            {
              
                cliente = controllerCliente.BuscarClientePorID(Convert.ToInt32(txtID.Text));
                cliente.Nome     = txtNome.Text;
                cliente.CPF      = txtCPF.Text;
                cliente.Email    = txtEmail.Text;
                cliente.Telefone = txtTelefone.Text;
                controllerCliente.AlterCliente(cliente);

                MessageBox.Show("Cliente alterado com sucesso!! ");
                dgDadosCliente.Items.Refresh();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao alterar Cliente (" + ex.Message + ")");
            }
           
        }

        private void btn_Excluir(object sender, RoutedEventArgs e)
        {
            try
            {
                cliente = controllerCliente.BuscarClientePorID(Convert.ToInt32(txtID.Text));
                if (cliente != null)
                controllerCliente.Excluir((Convert.ToInt32(txtID.Text)));
                MessageBox.Show("Cliente excluido com sucesso!");
                dgDadosCliente.Items.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao excluir Cliente (" + ex.Message + ")");
            }
           
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
