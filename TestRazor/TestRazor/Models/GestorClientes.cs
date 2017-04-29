using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestRazor.Models.AccesoDatos;

namespace TestRazor.Models
{
    public class GestorClientes
    {

        RepositorioCliente repo = new RepositorioCliente();

        public void Guardar(Cliente cliente)
        {
            repo.Guardar(cliente);
        }

        public List<Cliente> Listar()
        {
            return repo.Listar();
        }
    }
}