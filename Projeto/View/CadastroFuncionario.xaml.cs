using Controllers;
using Models;
using System;
using System.Windows;

namespace View
{
    /// <summary>
    /// Interaction logic for CadastroFuncionario.xaml
    /// </summary>
    public partial class CadastroFuncionario : Window
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }
        private void btnSalvarFun(object sender, RoutedEventArgs e)
        {
            try
            {
                Funcionario funcionario = new Funcionario();

                funcionario.Nome = txtNome.Text;
                funcionario.Funcao = txtFuncao.Text;
                funcionario.Telefone = txtTelefone.Text;        

                ControllerFuncionario controllerFuncionario = new ControllerFuncionario();
                controllerFuncionario.CadastrarFuncionario(funcionario);

                MessageBox.Show("Funcionario salvo com sucesso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar funcionario (" + ex.Message + ")");
            }
        }
    }
}
