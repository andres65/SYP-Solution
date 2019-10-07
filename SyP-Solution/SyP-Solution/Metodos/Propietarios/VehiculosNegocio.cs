using SyP_Solution.Data.Vehiculo;
using SyP_Solution.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SyP_Solution.Metodos.Propietarios
{
    public class VehiculosNegocio
    {
        public bool AgregarVehiculo(VehiculoEntity vehiculo)
        {
            VehiculoData pData = new VehiculoData();
            bool insertar = pData.AgregarVehiculo(vehiculo);
            return insertar;
            
        }


        public bool EditarVehiculo(VehiculoEntity vehiculo)
        {
            VehiculoData pData = new VehiculoData();
            bool editar = pData.EditarVehiculo(vehiculo);
            return editar;
        }

        public bool EliminarVehiculo(VehiculoEntity vehiculo)
        {
            VehiculoData pData = new VehiculoData();
            bool eliminar = pData.EliminarVehiculo(vehiculo);
            return eliminar;
        }
    }
}