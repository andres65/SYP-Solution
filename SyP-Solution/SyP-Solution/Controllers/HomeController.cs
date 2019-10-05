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
        public ActionResult EditarPropietario(int? Id)
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}