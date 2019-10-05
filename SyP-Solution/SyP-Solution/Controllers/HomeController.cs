using SyP_Solution.Metodos.Propietarios;
using SyP_Solution.Models;
using SyP_Solution.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SyP_Solution.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            List<PropietarioEntity > lstProp = new List<PropietarioEntity>();

            using (DBPruebaEntities db = new DBPruebaEntities())
            {
                lstProp = (from p in db.PROPIETARIO
                           select new SyP_Solution.Models.Entity.PropietarioEntity 
                           {

                               intId = p.ID,
                               strNumeeroIdentificacion = p.NUMEROIDENTIFICACION ,
                               strNombre = p.NOMBRES ,
                               strApellido = p.APELLIDOS ,
                               strDireccion = p.DIRECCION ,
                               strTelefono = p.TELEFONO ,
                               strCorreo = p.CORREOELECTRONICO 

                           }
                    ).ToList();
            }

            return View(lstProp);
        }

        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult EditarPropietario(int id,string idU, string nombre, string apellido, string direccion, string email, string telefono)
        {
            PropietariosNegocio nPropietario = new PropietariosNegocio();
            bool editar = nPropietario.EditarPropietario(new PropietarioEntity {  intId = id, strNombre = nombre, strApellido = apellido, strDireccion = direccion, strCorreo = email, strTelefono = telefono, strNumeeroIdentificacion = idU }); 

            return PartialView ("ViewPage1");
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}