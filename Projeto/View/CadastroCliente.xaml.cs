using Models;
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
    /// Interaction logic for CadastroCliente.xaml
    /// </summary>
    public partial class CadastroCliente : Window
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();

                cliente.Nome = txtNome.Text;
                cliente.CPF = txtCPF.Text;
                cliente.Telefone = txtCPF.Text;
                cliente.Email = txtEmail.Text;

                ControllerCliente controllerCliente = new ControllerCliente();
                controllerCliente.CadastrarCliente(cliente);

                MessageBox.Show("Cliente salvo com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar Cliente (" + ex.Message + ")");
            }
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}