//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SyP_Solution.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VEHICULO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VEHICULO()
        {
            this.FACTURA = new HashSet<FACTURA>();
            this.PROPIETARIO = new HashSet<PROPIETARIO>();
        }
    
        public int ID { get; set; }
        public string PLACA { get; set; }
        public Nullable<int> ID_LINEA { get; set; }
        public string MODELO { get; set; }
        public string NUMEROMOTOR { get; set; }
        public string COLOR { get; set; }
        public Nullable<int> ID_CLASE { get; set; }
        public Nullable<int> ID_TIPOSERVICIO { get; set; }
    
        public virtual CLASEVEHICULO CLASEVEHICULO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURA> FACTURA { get; set; }
        public virtual LINEA LINEA { get; set; }
        public virtual TIPOSERVICIO TIPOSERVICIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROPIETARIO> PROPIETARIO { get; set; }
    }
}
