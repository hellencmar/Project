using System.Windows;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEspacoCli(object sender, RoutedEventArgs e)
        {
            ClienteMenu cliMenu = new ClienteMenu();
            cliMenu.ShowDialog();
        }

        private void btnEspacoFun(object sender, RoutedEventArgs e)
        {
            FuncionarioMenu funMenu = new FuncionarioMenu();
            funMenu.ShowDialog();
        }
        private void btnAnotacao(object sender, RoutedEventArgs e)
        {
            CriarAnotacao criarAnotacao = new CriarAnotacao();
            criarAnotacao.ShowDialog();
        }
    }
}