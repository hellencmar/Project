using Controllers;
using Models;
using System;
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
        ControllerAnotacao controllerAnotacao = new ControllerAnotacao();       

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
            dgAnotacao.Items.Refresh();
            dgAnotacao.ItemsSource = controllerAnotacao.ListAnotacoes();           
        }

        private void dgAnotacao_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (dgAnotacao.SelectedIndex >= 0)
            {
               
                btnExcluir.IsEnabled = true;               
                anotacao = (Anotacao)dgAnotacao.SelectedItem;
                txtAssunto.Text = anotacao.Assunto;
                txtDescricao.Text = anotacao.Descricao;                
            }
           
        }

        private void BtnExcluir(object sender, RoutedEventArgs e)
        {
            try
            {
                anotacao = (Anotacao)dgAnotacao.SelectedItem;
                Anotacao anotacaoid = controllerAnotacao.BuscarAnotacaoPorID(anotacao.AnotacaoID);
                if (anotacao != null)
                    controllerAnotacao.Excluir(anotacao.AnotacaoID);
                MessageBox.Show("Anotação excluida");     



            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao excluir(" + ex.Message + ")");
            }

        }
        
    }
}