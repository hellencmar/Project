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
    /// Interaction logic for ClienteMenu.xaml
    /// </summary>
    public partial class ClienteMenu : Window
    {
        public ClienteMenu()
        {
            InitializeComponent();
        }
        private void btnCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            CadastroCliente cadUsu = new CadastroCliente();
            cadUsu.ShowDialog();
        }

        private void btnListarCliente_Click(object sender, RoutedEventArgs e)
        {
            ListarClientes listCli = new ListarClientes();
            listCli.ShowDialog();
        }

        private void btnGerenciarCli_Click(object sender, RoutedEventArgs e)
        {
            GerenciarCliente gerenciarCli = new GerenciarCliente();
            gerenciarCli.ShowDialog();

        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
