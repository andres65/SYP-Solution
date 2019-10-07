using SyP_Solution.Metodos.Propietarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SyP_Solution.Controllers
{
    public class CrearVehiculoController : Controller
    {
        // GET: CrearPropietario
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string placa, int idLinea, string modelo, string NumeroMotor, string color, int idClase, int idTipoServicio)
        {
            VehiculosNegocio pVehiculo = new VehiculosNegocio();
            pVehiculo.AgregarVehiculo(new Models.Entity.VehiculoEntity { strPlaca = placa, intIdLinea = idLinea, strModelo = modelo, strNumeroMotor = NumeroMotor, strColor = color, intIdClase = idClase, intIdTipoServicio = idTipoServicio });
            // Aquí cualquier uso de las variables 'usr', 'pwd' y 'rme'
            return View("Index");
        }
    }
}