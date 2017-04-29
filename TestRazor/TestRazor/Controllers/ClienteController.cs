using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
    }
}