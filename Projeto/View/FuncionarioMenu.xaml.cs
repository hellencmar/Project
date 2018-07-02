using System.Windows;

namespace View
{
    /// <summary>
    /// Interaction logic for FuncionarioMenu.xaml
    /// </summary>
    public partial class FuncionarioMenu : Window
    {
        public FuncionarioMenu()
        {
            InitializeComponent();
        }

        private void btnCadastrarFunc(object sender, RoutedEventArgs e)
        {
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();
            cadastroFuncionario.ShowDialog();
        }

        private void btnListarFuncionarios(object sender, RoutedEventArgs e)
        {
            ListarFuncionarios listarFuncionarios = new ListarFuncionarios();
            listarFuncionarios.ShowDialog();
        }

        private void btListarPorFuncao(object sender, RoutedEventArgs e)
        {
            ListarFuncionarioPorFuncao listFuncao = new ListarFuncionarioPorFuncao();
            listFuncao.ShowDialog();
        }

        private void btnGerenciarFuncionarios(object sender, RoutedEventArgs e)
        {
            GerenciarFuncionario gerenciarFuncionario = new GerenciarFuncionario();
            gerenciarFuncionario.ShowDialog();
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
