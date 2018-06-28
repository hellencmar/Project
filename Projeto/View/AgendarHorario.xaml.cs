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
    /// Interaction logic for AgendarHorario.xaml
    /// </summary>
    public partial class AgendarHorario : Window
    {
        public AgendarHorario()
        {
            InitializeComponent();
        }
        private void Hora_Loaded(object sender, RoutedEventArgs e)
        {

            cbHora.Items.Add("8");
            cbHora.Items.Add("9");
            cbHora.Items.Add("10");
            cbHora.Items.Add("11");
            cbHora.Items.Add("12");
            cbHora.Items.Add("13");
            cbHora.Items.Add("14");
            cbHora.Items.Add("15");
            cbHora.Items.Add("16");
            cbHora.Items.Add("17");
            cbHora.Items.Add("18");
            cbHora.Items.Add("19");
            cbHora.Items.Add("20");
        }

        private void Minuto_Loaded(object sender, RoutedEventArgs e)
        {
            cbMinuto.Items.Add("00");
            cbMinuto.Items.Add("05");
            cbMinuto.Items.Add("10");
            cbMinuto.Items.Add("15");
            cbMinuto.Items.Add("20");
            cbMinuto.Items.Add("25");
            cbMinuto.Items.Add("30");
            cbMinuto.Items.Add("35");
            cbMinuto.Items.Add("40");
            cbMinuto.Items.Add("45");
            cbMinuto.Items.Add("50");
            cbMinuto.Items.Add("55");           
        }
    }
}
