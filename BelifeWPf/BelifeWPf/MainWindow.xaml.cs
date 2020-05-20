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
using BeLife.Negocio;

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

            CargarSexo();
            CargarEstado();
        }

        private void Btn_despliegaFly_Click(object sender, RoutedEventArgs e)
        {
            fly.IsOpen = true;
        }

        private async void Cerrar(object sender, RoutedEventArgs e)
        {
            MessageDialogResult Result = await this.ShowMessageAsync("Confirmación", "¿Está Seguro que Desea Cerrar la Aplicación?", MessageDialogStyle.AffirmativeAndNegative);

            if (Result == MessageDialogResult.Affirmative)
            {
                this.Close();
            }
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

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void TCPrincipal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Cbsexo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        /*
        0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000 

                                        TabItem 1 Registrar cliente

        0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000 
        */
        private void Limpiar()
        {

            TxRut.Text = string.Empty;
            TxNombres.Text = string.Empty;
            TxApellidos.Text = string.Empty;
            DpFechaNacimiento.SelectedDate = DateTime.Today;
            CbSexo.SelectedIndex = 0;
            CbEstadoCivil.SelectedIndex = 0;

            CargarSexo();
            CargarEstado();
            //CargarCliente();

        }


        private void CargarSexo()
        {
            /* Carga todas los cliente */
            Sexo sexo = new Sexo();
            CbSexo.ItemsSource = sexo.ReadAllSexo();

            /* Configura los datos en el ComboBOx */
            CbSexo.DisplayMemberPath = "Descripcion"; //Propiedad para mostrar
            CbSexo.SelectedValuePath = "Descripcion"; //Propiedad con el valor a rescatar

            CbSexo.SelectedIndex = 0; //Posiciona en el primer registro

        }

        private void CargarEstado()
        {
            /* Carga todas los cliente */
            Estado estado = new Estado();
            CbEstadoCivil.ItemsSource = estado.ReadAllEstado();

            /* Configura los datos en el ComboBOx */
            CbEstadoCivil.DisplayMemberPath = "Descripcion"; //Propiedad para mostrar
            CbEstadoCivil.SelectedValuePath = "Descripcion"; //Propiedad con el valor a rescatar

            CbEstadoCivil.SelectedIndex = 0; //Posiciona en el primer registro

        }



        /*
        0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000 

                                        TabItem 2 Lista clientes

        0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000 
        */




        /*
        0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000 

                                        TabItem 3 Registrar contrato

        0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000 
        */




        /*
        0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000 

                                        TabItem 4 Lista contratos

        0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000 
        */


    }
}
