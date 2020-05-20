using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife.Negocio
{
    public class Cliente
    {
        public string RutCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string IdSexo { get; set; }
        public string IdEstadoCivil { get; set; }



        public Cliente()
        {
            this.Init();
        }
        public void Init()
        {
            RutCliente = string.Empty;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            FechaNacimiento = DateTime.Today;
            IdSexo = string.Empty;
            IdEstadoCivil = string.Empty;
        }

        //agregar el nuevo cliente en la base de dato y guarda los cambios de esta.
        public bool Create()
        {
            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();
            Datos.Cliente cli = new Datos.Cliente();

            try
            {
                CommonBC.Syncronize(this, cli);

                cli.IdEstadoCivil = ObtenerIdCivil();
                cli.IdSexo = ObtenerIdSexo();

                bbdd.Cliente.Add(cli);
                bbdd.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                bbdd.Cliente.Remove(cli);
                return false;
            }

        }

        private int ObtenerIdCivil()
        {
            //comparando la descripcion de la base de datos con la de la vista para retornar la id 
            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();
            Datos.EstadoCivil estadoCivil = bbdd.EstadoCivil.First(s => s.Descripcion == IdEstadoCivil);
            int Id = estadoCivil.IdEstadoCivil;
            return Id;
        }

        private int ObtenerIdSexo()
        {
            Datos.BeLifeEntities bbdd = new Datos.BeLifeEntities();
            Datos.Sexo sexoDes = bbdd.Sexo.First(s => s.Descripcion == IdSexo);
            int Id = sexoDes.IdSexo;
            return Id;
        }
    }
}
