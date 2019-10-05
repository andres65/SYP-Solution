using SyP_Solution.Data.Propietario;
using SyP_Solution.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SyP_Solution.Metodos.Propietarios
{
    public class PropietariosNegocio
    {
        public bool AgegarPropietario(PropietarioEntity propietario)
        {
            PropietarioData pData = new PropietarioData();
            bool insertar = pData.AgegarPropietario(propietario);          
            return insertar;
        }

        public bool EditarPropietario(PropietarioEntity propietario)
        {
            PropietarioData pData = new PropietarioData();
            bool editar = pData.EditarPropietario (propietario);
            return editar;
        }
    }
}