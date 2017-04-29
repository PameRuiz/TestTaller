using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestRazor.Models;
using TestRazor.ViewModel;

namespace TestRazor.Controllers
{
    public class ProductoController : Controller
    {
        GestorProductos gestor = new GestorProductos();
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Guardar(Productos producto)
        {
            if (ModelState.IsValid)
            {
                gestor.Guardar(producto);
            }
            else
            {
                return View("FormularioProducto");
            }
            return View("Index");
        }
    }
    }
