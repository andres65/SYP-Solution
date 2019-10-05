using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SyP_Solution.Models.Entity
{
    public class PropietarioEntity
    {
        public int intId { get; set; }
        public string  strNumeeroIdentificacion { get; set; }
        public string  strNombre { get; set; }
        public string  strApellido { get; set; }
        public string  strDireccion { get; set; }
        public string  strTelefono { get; set; }
        public string  strCorreo { get; set; }
    }
}