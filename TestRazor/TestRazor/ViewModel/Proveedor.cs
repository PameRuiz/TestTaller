using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestRazor.ViewModel
{
    public class Proveedor
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Telefono { get; set; }
    }
}