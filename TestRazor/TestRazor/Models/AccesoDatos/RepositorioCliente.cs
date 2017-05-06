using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestRazor.Common;

namespace TestRazor.Models.AccesoDatos
{
    public class RepositorioCliente
    {
        TallerDB tallerDB = new TallerDB();
        public RepositorioCliente()
        {
            tallerDB.Database.Log = Logger.Log;
        }
        public void Guardar(Cliente cliente)
        {
            tallerDB.Cliente.Add(cliente);
            tallerDB.SaveChanges();
        }

        public List<Cliente> Listar()
        {
            return tallerDB.Cliente.ToList();
        }

        public List<Cliente> Buscar(string cliente)
        {
            return tallerDB.Cliente.Where(x => x.Apellido.Contains(cliente) || x.Nombre.Contains(cliente)).ToList();
        }

        public void Eliminar(int id) {
            var cliente = tallerDB.Cliente.First(x => x.Id == id);
            tallerDB.Cliente.Remove(cliente);
            tallerDB.SaveChanges();
        }

        public void Eliminar(string apellido, string nombre)
        {
            var cliente = tallerDB.Cliente.Where(x => x.Apellido == apellido && x.Nombre == nombre).First();
            tallerDB.Cliente.Remove(cliente);
            tallerDB.SaveChanges();
        }
    }
}