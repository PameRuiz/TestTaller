using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestRazor.Models.AccesoDatos
{
    public class RepositorioCliente
    {
        TallerDB tallerDB = new TallerDB();
        public void Guardar(Cliente cliente)
        {
            tallerDB.Cliente.Add(cliente);
            tallerDB.SaveChanges();
        }

        public List<Cliente> Listar()
        {
            return tallerDB.Cliente.ToList();
        }

        public void Eliminar(int id) { 
            //tallerDB.Cliente.Remove(tallerDB.Cliente.Where())
        }

        public void Eliminar(string apellido, string nombre)
        {
            tallerDB.Cliente.Where(x => x.Apellido == apellido && x.Nombre == nombre).First();
        }
    }
}