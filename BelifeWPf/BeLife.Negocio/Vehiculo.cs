using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BeLife.Datos;

namespace BeLife.Negocio
{
    public class Vehiculo
    {
        public string Patente { get; set; }
        public int IdMarca { get; set; }
        public int IdModelo { get; set; }
        public int Anho { get; set; }

        public Vehiculo()
        {

            this.Init();
        }

        private void Init()
        {
            Patente = string.Empty;
            IdMarca = 0;
            IdModelo = 0;
            Anho = 0;
        }

        public List<BeLife.Datos.MarcaVehiculo> listaMarcas()
        {
            BeLifeEntities bd = new BeLifeEntities();
            var result = from d in bd.MarcaVehiculo
                         select d;
            return result.ToList();
        }


        public List<BeLife.Datos.ModeloVehiculo> listaModelos(int idmarca)
        {
            BeLifeEntities bd = new BeLifeEntities();
            var result = (from b in bd.MarcaModeloVehiculo
                          where b.IdMarca == idmarca
                          select b.IdModelo).ToList();

            var result2 = from a in bd.ModeloVehiculo
                          where result.Contains(a.IdModelo)
                          select a;

            return result2.ToList();
        }
    }
}
