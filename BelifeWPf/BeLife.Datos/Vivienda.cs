//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeLife.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vivienda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vivienda()
        {
            this.Contrato = new HashSet<Contrato>();
        }
    
        public int CodigoPostal { get; set; }
        public int Anho { get; set; }
        public string Direccion { get; set; }
        public double ValorInmueble { get; set; }
        public double ValorContenido { get; set; }
        public int IdRegion { get; set; }
        public int IdComuna { get; set; }
    
        public virtual RegionComuna RegionComuna { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato { get; set; }
    }
}
