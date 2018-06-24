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
    /// Interaction logic for EditarCliente.xaml
    /// </summary>
    public partial class EditarCliente : Window
    {
        public EditarCliente()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ControllerCliente controllerCliente = new ControllerCliente();
            dgDadosCliente.ItemsSource = controllerCliente.ListTodosClientes();
        }

        private void dgDadosCliente_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (dgDadosCliente.SelectedIndex > 0)
                {
                    Cliente c = (Cliente)dgDadosCliente.SelectedItem;
                    txtNome.Text = c.Nome;
                    txtCPF.Text = c.CPF;
                    txtEmail.Text = c.Email;
                    txtTelefone.Text = c.Telefone;          
             
                 }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
