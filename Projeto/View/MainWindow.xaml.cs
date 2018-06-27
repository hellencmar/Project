﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        private void btn_Agendar(object sender, RoutedEventArgs e)
        {
            AgendarHorario agendar = new AgendarHorario();
            agendar.ShowDialog();

            
        }
    }
}