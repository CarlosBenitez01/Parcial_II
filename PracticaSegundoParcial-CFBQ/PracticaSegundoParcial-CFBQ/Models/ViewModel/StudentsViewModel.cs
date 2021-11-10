using PracticaSegundoParcial_CFBQ.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSegundoParcial_CFBQ.Models.ViewModel
{
    public class StudentsViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "LastName")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public String LastName { get; set; }

        [Display(Name = "FirstMidName")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public String FirstMidName { get; set; }

        [Display(Name = "EnrollementsDate")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime EnrollementsDate { get; set; }

    }
}
