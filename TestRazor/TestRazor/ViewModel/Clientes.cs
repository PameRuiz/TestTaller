using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TestRazor.Models;
using System.Web.Mvc;

namespace TestRazor.ViewModel
{
    public class Clientes
    {       
            [HiddenInput(DisplayValue = false)]
            public int? Id { get; set; }
            [Required(ErrorMessage ="Te olvidaste de completar este campo!!!")]
            public string Apellido { get; set; }
            [Required]
            [StringLength(maximumLength:20,ErrorMessage ="El nombre no puede tener mas de 20 caracteres",MinimumLength =1)]
            public string Nombre { get; set; }
            [DisplayName("Apellido de Soltera")]
            [Required]
            public string ApellidoDeSoltera { get; set; }

        [Required]
            //[Range(15,50,ErrorMessage ="La edad debe estar entre 15 y 50")]
            [ValidarEdad]
            public int Edad { get; set; }
            [Required]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }
        }
    }

