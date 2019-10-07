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

        [HttpPost]
        public ActionResult EditarPropietario(int id, string idU, string nombre, string apellido, string direccion, string email, string telefono)
        {
            PropietariosNegocio nPropietario = new PropietariosNegocio();
            bool editar = nPropietario.EditarPropietario(new PropietarioEntity { intId = id, strNombre = nombre, strApellido = apellido, strDireccion = direccion, strCorreo = email, strTelefono = telefono, strNumeeroIdentificacion = idU });

            return PartialView("MensajeExito");
        }

        [HttpPost]
        public ActionResult EliminarPropietario(int id)
        {
            PropietariosNegocio nPropietario = new PropietariosNegocio();
            bool eliminar = nPropietario.EliminarPropietario(new PropietarioEntity { intId = id });
            return PartialView("MensajeExito");
        }

        public ActionResult About()
        {
            List<VehiculoEntity> lstProp = new List<VehiculoEntity>();

            using (DBPruebaEntities db = new DBPruebaEntities())
            {
                lstProp = (from p in db.VEHICULO
                           select new SyP_Solution.Models.Entity.VehiculoEntity
                           {

                               intId = p.ID,
                               strPlaca = p.PLACA,
                               intIdLinea = p.ID_LINEA,
                               strModelo = p.MODELO,
                               strNumeroMotor = p.NUMEROMOTOR,
                               strColor = p.COLOR,
                               intIdClase = p.ID_CLASE,
                               intIdTipoServicio = p.ID_TIPOSERVICIO

                           }
                    ).ToList();
            }

            return View(lstProp);
        }

        [HttpPost]
        public ActionResult EditarVehiculo(int id, string placa, int idLinea, string modelo, string NumeroMotor, string color, int idClase, int idTipoServicio)
        {
            VehiculosNegocio nVehiculo = new VehiculosNegocio();
            //PropietariosNegocio nPropietario = new PropietariosNegocio();
            bool editar = nVehiculo.EditarVehiculo(new VehiculoEntity { intId = id, strPlaca = placa, intIdLinea = idLinea, strModelo = modelo, strNumeroMotor = NumeroMotor, strColor = color, intIdClase = idClase, intIdTipoServicio = idTipoServicio });
            return PartialView("MensajeExito");
        }

        [HttpPost]
        public ActionResult EliminarVehiculo(int id)
        {
            VehiculosNegocio nVehiculo = new VehiculosNegocio();
            bool eliminar = nVehiculo.EliminarVehiculo(new VehiculoEntity { intId = id });
            return PartialView("MensajeExito");
        }



        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}