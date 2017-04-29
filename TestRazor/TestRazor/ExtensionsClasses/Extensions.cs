using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestRazor.Models;
using TestRazor.ViewModel;

namespace TestRazor.ExtensionsClasses
{
    public static class Extensions
    {

        public static Models.Cliente ConvertirAModelo(this ViewModel.Clientes clienteViewModel)
        {
            var cliente = new Cliente()
            {
                Apellido = clienteViewModel.Apellido,
                Nombre = clienteViewModel.Nombre,
                Edad = clienteViewModel.Edad
            };

            return cliente;
        }

        public static List<ViewModel.Clientes> ConvertirAViewModel(this List<Models.Cliente> clientes)
        {
            var listaViewModel = new List<ViewModel.Clientes>();

            foreach (var clienteDelModel in clientes)
            {
                var clienteViewModel = new Clientes()
                {
                    Apellido = clienteDelModel.Apellido,
                    Nombre = clienteDelModel.Nombre
                };
                listaViewModel.Add(clienteViewModel);
            }
            return listaViewModel;
        }
    }
}