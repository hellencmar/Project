using Controllers;
using Models;
using System;
using System.Windows;
using System.Windows.Input;

namespace View
{
    /// <summary>
    /// Interaction logic for GerenciarFuncionario.xaml
    /// </summary>
    public partial class GerenciarFuncionario : Window
    {
        Funcionario funcionario = new Funcionario();
        ControllerFuncionario controllerFuncionario = new ControllerFuncionario();
        public GerenciarFuncionario()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          
            dgDadosFuncionario.ItemsSource = controllerFuncionario.ListTodosFuncionarios();

        }

        private void dgDadosFuncionario_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dgDadosFuncionario.SelectedIndex >= 0)
            {
                funcionario = (Funcionario)dgDadosFuncionario.SelectedItem;
                txtID.Text = (Convert.ToString(funcionario.FuncionarioID)); 
                txtNome.Text = funcionario.Nome;
                txtFuncao.Text = funcionario.Funcao;
                txtTelefone.Text = funcionario.Telefone;  

            }
        }

        private void btn_Editar(object sender, RoutedEventArgs e)
        {
            try
            {

                funcionario = controllerFuncionario.BuscarFuncionarioPorID(Convert.ToInt32(txtID.Text));
                funcionario.Nome = txtNome.Text;
                funcionario.Funcao = txtFuncao.Text; 
                funcionario.Telefone = txtTelefone.Text;
                controllerFuncionario.AlterFuncionario(funcionario);

                MessageBox.Show("Funcionario alterado com sucesso!! ");
                dgDadosFuncionario.Items.Refresh();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao alterar Funcionario (" + ex.Message + ")");
            }

        }

        private void btn_Excluir(object sender, RoutedEventArgs e)
        {
            try
            {
                funcionario = controllerFuncionario.BuscarFuncionarioPorID(Convert.ToInt32(txtID.Text));
                if (funcionario != null)
                    controllerFuncionario.Excluir((Convert.ToInt32(txtID.Text)));
                MessageBox.Show("Funcionario excluido com sucesso!");             

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao excluir funcionario (" + ex.Message + ")");
            }

        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    }

