using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SyP_Solution.Models.Entity
{
    public class VehiculoEntity
    {
        //Mapeo de la base de datos tabla VEHICULO
        public int intId { get; set; }
        public string strPlaca { get; set; }
        public int? intIdLinea { get; set; }
        public string strModelo { get; set; }
        public string strNumeroMotor { get; set; }
        public string strColor { get; set; }
        public int? intIdClase { get; set; }
        public int? intIdTipoServicio { get; set; }
    }
}