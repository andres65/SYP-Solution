using SyP_Solution.Metodos.Propietarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SyP_Solution.Controllers
{
    public class CrearPropietarioController : Controller
    {
        // GET: CrearPropietario
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string idU, string nombre, string apellido, string direccion, string email,string telefono)
        {
            PropietariosNegocio vPropietario = new PropietariosNegocio();
            vPropietario.AgegarPropietario(new Models.Entity.PropietarioEntity { strNombre = nombre , strApellido = apellido , strDireccion = direccion , strCorreo = email , strTelefono = telefono , strNumeeroIdentificacion = idU });
            // Aquí cualquier uso de las variables 'usr', 'pwd' y 'rme'
            return View("Index");
        }
    }
}