﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestRazor.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TallerDB : DbContext
    {
        public TallerDB()
            : base("name=TallerDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
    
        public virtual ObjectResult<Nullable<int>> BuscarClientes(string apellido, string nombre)
        {
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("BuscarClientes", apellidoParameter, nombreParameter);
        }
    
        public virtual ObjectResult<ConsultaClientes_Result> ConsultaClientes(string apellido, string nombre)
        {
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultaClientes_Result>("ConsultaClientes", apellidoParameter, nombreParameter);
        }
    
        public virtual int EliminarClientes(string apellido, string nombre)
        {
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarClientes", apellidoParameter, nombreParameter);
        }
    
        public virtual int EliminarProductos(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarProductos", nombreParameter);
        }
    
        public virtual int EliminarProveedores(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarProveedores", nombreParameter);
        }
    
        public virtual int GuardarClientes(string apellido, string nombre, Nullable<int> edad)
        {
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var edadParameter = edad.HasValue ?
                new ObjectParameter("Edad", edad) :
                new ObjectParameter("Edad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GuardarClientes", apellidoParameter, nombreParameter, edadParameter);
        }
    
        public virtual int GuardarProductos(string nombre, Nullable<decimal> precio, Nullable<int> cantidad)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(decimal));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GuardarProductos", nombreParameter, precioParameter, cantidadParameter);
        }
    
        public virtual int GuardarProveedor(string nombre, Nullable<int> telefono)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var telefonoParameter = telefono.HasValue ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GuardarProveedor", nombreParameter, telefonoParameter);
        }
    
        public virtual ObjectResult<ListarClientes_Result> ListarClientes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarClientes_Result>("ListarClientes");
        }
    
        public virtual ObjectResult<ListarProductos_Result> ListarProductos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarProductos_Result>("ListarProductos");
        }
    
        public virtual ObjectResult<ListarProveedores_Result> ListarProveedores()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarProveedores_Result>("ListarProveedores");
        }
    
        public virtual int ModificarClientes(string apellido, string nombre, Nullable<int> edad, Nullable<int> id)
        {
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var edadParameter = edad.HasValue ?
                new ObjectParameter("Edad", edad) :
                new ObjectParameter("Edad", typeof(int));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModificarClientes", apellidoParameter, nombreParameter, edadParameter, idParameter);
        }
    
        public virtual int ModificarProductos(string nombre, Nullable<decimal> precio, Nullable<int> cantidad, Nullable<int> id)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(decimal));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModificarProductos", nombreParameter, precioParameter, cantidadParameter, idParameter);
        }
    
        public virtual int ModificarProveedores(string nombre, Nullable<int> telefono, Nullable<int> indice)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var telefonoParameter = telefono.HasValue ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(int));
    
            var indiceParameter = indice.HasValue ?
                new ObjectParameter("indice", indice) :
                new ObjectParameter("indice", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModificarProveedores", nombreParameter, telefonoParameter, indiceParameter);
        }
    }
}
