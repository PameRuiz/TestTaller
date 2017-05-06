using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestRazor.Common;
using TestRazor.ExtensionsClasses;
using TestRazor.Models;
using TestRazor.ViewModel;

namespace TestRazor.Controllers
{
    public class ClienteController : Controller
    {
        GestorClientes gestor = new GestorClientes();
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Alta()
        {
            return View();
        }
        public ActionResult Guardar(Clientes clienteViewModel)
        {
           
            if (ModelState.IsValid)
            {
                gestor.Guardar(clienteViewModel.ConvertirAModelo());
            }
            else
            {
                return View("Alta");
            }
            return RedirectToAction("Listar");
        }

        public ActionResult Listar()
        {
            var clientes = gestor.Listar();

           
            return View(clientes.ConvertirAViewModel());
        }

        public ActionResult Buscar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Busqueda(string cliente)
        {
            Logger.Log("Pasó por el action busqueda");
            var clientes = gestor.Buscar(cliente);
            return View(clientes.ConvertirAViewModel());
        }

        public ActionResult EliminarPorId(int id)
        {
            gestor.Eliminar(id);
            return RedirectToAction("Listar");
        }

        public ActionResult EliminarPorApellidoyNombre(string apellido, string nombre)
        {
            gestor.Eliminar(apellido, nombre);
            return RedirectToAction("Listar");
        }
    }
}