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
    /// Interaction logic for CriarAnotacao.xaml
    /// </summary>
    public partial class CriarAnotacao : Window
    {
        ControllerAnotacao controllerAnotacao = new ControllerAnotacao();
        DateTime dateTime = new DateTime();
        
        public CriarAnotacao()
        {
            InitializeComponent();
        }

        private void Form_Loaded(object sender, RoutedEventArgs e)
        {
            dateTime = DateTime.Now;
            txtDataHora.Text = dateTime.ToLongDateString();
        }

        private void btnSalvar(object sender, RoutedEventArgs e)
        {
            try
            {
                dateTime = DateTime.Now;
                Anotacao anotacao = new Anotacao();
                anotacao.Assunto = txtTitulo.Text;
                anotacao.Descricao = txtDescricao.Text;
                anotacao.DataAnotacao = dateTime;
                controllerAnotacao.CadastrarAnotacao(anotacao);

                MessageBox.Show("Anotação salva com sucesso");
              
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar anotação (" + ex.Message + ")");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();           
        }
    }
}
