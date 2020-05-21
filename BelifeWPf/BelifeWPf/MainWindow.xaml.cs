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
            //regristro Cliente
            Limpiar();
            CargarCliente();

            //BtFiltroListadoCliente 
            LimpiarF();
            CargarEstadoF();
            CargarSexoF();

            //registro contrato


            //Listado de contratos
            CargarContratos();

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
        public void Limpiar()
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


        public void CargarSexo()
        {
            
            /* Carga todas los cliente */
            Sexo sexo = new Sexo();
            CbSexo.ItemsSource = sexo.ReadAllSexo();

            /* Configura los datos en el ComboBOx */
            CbSexo.DisplayMemberPath = "Descripcion"; //Propiedad para mostrar
            CbSexo.SelectedValuePath = "Descripcion"; //Propiedad con el valor a rescatar

            CbSexo.SelectedIndex = 0; //Posiciona en el primer registro

        }

        public void CargarEstado()
        {
            /* Carga todas los cliente */
            Estado estado = new Estado();
            CbEstadoCivil.ItemsSource = estado.ReadAllEstado();

            /* Configura los datos en el ComboBOx */
            CbEstadoCivil.DisplayMemberPath = "Descripcion"; //Propiedad para mostrar
            CbEstadoCivil.SelectedValuePath = "Descripcion"; //Propiedad con el valor a rescatar

            CbEstadoCivil.SelectedIndex = 0; //Posiciona en el primer registro

        }
                      


        //basura
        private void CbEstadoCivil_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        //

        //BOTON REGISTRAR cliente listo no tocar 
        private async void BtRegistrarCliente_Click_1(object sender, RoutedEventArgs e)
        {

            Cliente cli = new Cliente()
            {
                RutCliente = TxRut.Text,
                Nombres = TxNombres.Text,
                Apellidos = TxApellidos.Text,
                FechaNacimiento = DateTime.Today,
                IdSexo = CbSexo.SelectedValue.ToString(),
                IdEstadoCivil = CbEstadoCivil.SelectedValue.ToString()
            };


            if (cli.Create())
            {
                await this.ShowMessageAsync("Exito", "Cliente Registrado");
                Limpiar();
            }
            else
            {
                await this.ShowMessageAsync("Error", "No se registro el Cliente");
            }
        }


        //BOTON BUSCAR
        private async void BtBuscarCliente_Click(object sender, RoutedEventArgs e)
        {
            //BOTON BUSCAR SI el cliente esta registrado
            Cliente cli = new Cliente()
            {
                RutCliente = TxRut.Text
            };

            if (cli.Read())
            {
                TxNombres.Text = cli.Nombres;
                TxApellidos.Text = cli.Apellidos;
                DpFechaNacimiento.SelectedDate = cli.FechaNacimiento;
                CbSexo.SelectedValue = cli.IdSexo;
                CbEstadoCivil.SelectedValue = cli.IdEstadoCivil;


                await this.ShowMessageAsync("Exito", "Cliente Leído");
            }
            else
            {
                await this.ShowMessageAsync("Intentalo Nuevamente", "Cliente No ha sido Leído");
            }
        }



        //BOTON ACTUALIZAR
        private async void BtActualizarCliente_Click(object sender, RoutedEventArgs e)
        {
            //BOTON ACTUALIZAR datos del cliente
            Cliente cli = new Cliente()
            {
                RutCliente = TxRut.Text,
                Nombres = TxNombres.Text,
                Apellidos = TxApellidos.Text,
                FechaNacimiento = DpFechaNacimiento.SelectedDate.Value,
                IdSexo = CbSexo.SelectedValue.ToString(),
                IdEstadoCivil = CbEstadoCivil.SelectedValue.ToString()

            };

            if (cli.Update())
            {
                await this.ShowMessageAsync("Exito", "Cliente Actualizado");
                Limpiar();
            }
            else
            {
                await this.ShowMessageAsync("Intentalo Nuevamente", "Cliente no pudo ser Actualizado");
            }
        }


        //BOTON ELIMINAR
        private async void BtEliminarCliente_Click(object sender, RoutedEventArgs e)
        {
            //BOTON ELIMINAR al cliente 
            Cliente cli = new Cliente()
            {
                RutCliente = TxRut.Text
            };
            if (cli.Delete())
            {
                await this.ShowMessageAsync("Exito", "Cliente Eliminado");
                Limpiar();

            }
            else
            {
                await this.ShowMessageAsync("Intentalo Nuevamente", "Cliente No Pudo Ser Eliminado");
            }
        }

        private void BtLimpiarCliente_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }







        /*
        0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000 

                                        TabItem 2 Lista clientes

        0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000 
        */

        private void LimpiarF()
        {

            TxFiltrarRut.Text = string.Empty;
            CbFiltrarSexo.SelectedIndex = 0;
            CbFiltrarEstadoCivil.SelectedIndex = 0;
           
            CargarSexoF();
            CargarEstadoF();
            

        }

        private void CargarSexoF()
        {
            /* Carga todas los cliente */
            Sexo sexo = new Sexo();
            CbFiltrarSexo.ItemsSource = sexo.ReadAllSexo();

            /* Configura los datos en el ComboBOx */
            CbFiltrarSexo.DisplayMemberPath = "Descripcion"; //Propiedad para mostrar
            CbFiltrarSexo.SelectedValuePath = "IdSexo"; //Propiedad con el valor a rescatar
            CbFiltrarSexo.SelectedIndex = 0; //Posiciona en el primer registro

        }
        private void CargarEstadoF()
        {
            /* Carga todas los cliente */
            Estado estado = new Estado();
            CbFiltrarEstadoCivil.ItemsSource = estado.ReadAllEstado();

            /* Configura los datos en el ComboBOx */
            CbFiltrarEstadoCivil.DisplayMemberPath = "Descripcion"; //Propiedad para mostrar
            CbFiltrarEstadoCivil.SelectedValuePath = "IdEstadoCivi"; //Propiedad con el valor a rescatar
            CbFiltrarEstadoCivil.SelectedIndex = 0; //Posiciona en el primer registro

        }


        public void CargarCliente()
        {

            //cargar los empleados en la data grid 
            Cliente clientes = new Cliente();
            DGlistadoClientes.ItemsSource = clientes.ReadAll();


        }

        public void filtro()
        {
            Cliente cli = new Cliente();
            DGlistadoClientes.ItemsSource = cli.ReadSE(TxFiltrarRut.Text, CbFiltrarSexo.SelectedIndex, CbFiltrarEstadoCivil.SelectedIndex);
        }

        private void BtFiltroListadoCliente_Click(object sender, RoutedEventArgs e)
        {
            filtro();
        }

        /*
        0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000 

                                        TabItem 3 Registrar contrato

        0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000 
        */

        //cargar el combobox 
        private void CargarContrato()
        {
            //Carga todas los contratos */
            Plan plan = new Plan();
            CbCodigoPlan.ItemsSource = plan.ReadAllPlan();

            /* Configura los datos en el ComboBOx */
            CbCodigoPlan.DisplayMemberPath = "IdPlan"; //Propiedad para mostrar
            CbCodigoPlan.SelectedValuePath = "IdPlan"; //Propiedad con el valor a rescatar

            CbCodigoPlan.SelectedIndex = 0; //Posiciona en el primer registro

        }


        /*
        0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000 

                                        TabItem 4 Lista contratos

        0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000 
        */

        private void CargarContratos()
        {
            /* Carga todos los Empleados */
            Contrato contrato = new Contrato();
            DGListadoContrato.ItemsSource = contrato.ReadAll();
        }
        public void BFiltro()
        {
            Contrato con = new Contrato();
            DGListadoContrato.ItemsSource = con.ReadS(TxNumFiltroContrato.Text, TxRutFiltroContrato.Text, CBFiltroNumPoliza.SelectedIndex);
        }//filtro

        private void Filtrarcont(object sender, RoutedEventArgs e)
        {
            BFiltro();
        }
    }
}
