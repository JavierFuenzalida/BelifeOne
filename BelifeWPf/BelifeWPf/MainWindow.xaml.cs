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
using System.Windows.Navigation;
using System.Windows.Shapes;

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

namespace BelifeWPf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_despliegaFly_Click(object sender, RoutedEventArgs e)
        {
            fly.IsOpen = true;
        }

        private void Cerrar(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Minimizar(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtCliente_Click(object sender, RoutedEventArgs e)
        {
            TCPrincipal.SelectedIndex = 0;
            fly.IsOpen = false;
        }

        private void BtBusCliente_click(object sender, RoutedEventArgs e)
        {
            TCPrincipal.SelectedIndex = 1;
            fly.IsOpen = false;
        }

        private void BtContrato_Click(object sender, RoutedEventArgs e)
        {
            TCPrincipal.SelectedIndex = 2;
            fly.IsOpen = false;
        }

        private void BtbusContrato_Click(object sender, RoutedEventArgs e)
        {
            TCPrincipal.SelectedIndex = 3;
            fly.IsOpen = false;
        }
    }
}
