using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestRazor.Models
{
    public class GestorVentas
    {
        public List<Producto> ObtenerProductos()
        {
            var harina = new Producto { Nombre = "Harina" };
            var arroz = new Producto { Nombre = "Arroz" };
            var fideos = new Producto { Nombre = "Fideos" };

            var listaProductos = new List<Producto>();
            listaProductos.Add(arroz);
            listaProductos.Add(harina);
            listaProductos.Add(fideos);
            return listaProductos;
        }

        public List<Cliente> ObtenerClientes()
        {
            var cliente1 = new Cliente { Apellido = "Ruiz", Nombre = "Pamela" };
            var cliente2 = new Cliente { Apellido = "Facundo", Nombre = "Ledesma" };
            var cliente3 = new Cliente { Apellido = "Dip", Nombre = "Raul" };

            var listaClientes = new List<Cliente>();
            listaClientes.Add(cliente1);
            listaClientes.Add(cliente2);
            listaClientes.Add(cliente3);

            return listaClientes;

        }
    }
}