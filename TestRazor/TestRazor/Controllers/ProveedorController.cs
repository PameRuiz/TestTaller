using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestRazor.Models;


namespace TestRazor.Controllers
{
    public class ProveedorController : Controller
    {
        GestorProveedor gestor = new GestorProveedor();
        // GET: Proveedor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Guardar(ViewModel.Proveedor proveedor)
        {
            var proveedorModel = new Models.Proveedor();
            proveedorModel.Nombre = proveedor.Nombre;
            proveedorModel.Telefono = proveedor.Telefono;
            if (ModelState.IsValid)
            {
                gestor.Guardar(proveedorModel);
            }
            else
            {
                return View("FormularioProveedor");
            }
            return View("Home/Index");
        }
    }
    }
