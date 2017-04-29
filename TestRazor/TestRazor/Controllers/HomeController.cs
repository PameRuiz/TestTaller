using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestRazor.Models;
using TestRazor.ViewModel;

namespace TestRazor.Controllers
{
    public class HomeController : Controller
    {
        GestorClientes gestor = new GestorClientes();
        // GET: Home
        public ActionResult Index()
        {
            //var gestor = new GestorVentas();
            //var listaProductos = gestor.ObtenerProductos();
            //var listaClientes = gestor.ObtenerClientes();

            //var venta = new Venta();
            //venta.Clientes = listaClientes;
            //venta.Productos = listaProductos;
            return View();
        }

        public ActionResult Formulario()
        {
            return View();
        }

        public ActionResult FormularioProducto()
        {
            return View();
        }

        public ActionResult FormularioProveedor()
        {
            return View();
        }


    }




}