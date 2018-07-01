using Controllers;
using Models;
using System.Data;
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
        Anotacao anotacao = new Anotacao();

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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            ControllerAnotacao controlleAnotação = new ControllerAnotacao();
            dgAnotacao.ItemsSource = controlleAnotação.ListAnotacoes();           
        }

        private void dgAnotacao_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (dgAnotacao.SelectedIndex >= 0)
            {

                //var rowView = dgAnotacao.SelectedItems[0] as DataRowView;
                //string ID = rowView["AnotacaoID"].ToString(); //textbox idMarca
                //CriarAnotacao criarAnotacao = new CriarAnotacao();
                //criarAnotacao.ShowDialog(ID);

            }
           
        }
    }
}