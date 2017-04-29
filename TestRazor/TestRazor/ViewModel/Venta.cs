using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestRazor.Models;

namespace TestRazor.ViewModel
{
    public class Venta
    {
       public List<Producto> Productos { get; set; }
        public List<Clientes> Clientes { get; set; }
    }
}