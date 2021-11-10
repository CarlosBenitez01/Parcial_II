using PracticaSegundoParcial_CFBQ.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSegundoParcial_CFBQ.Models.ViewModel
{
    public class CourseViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public String Title { get; set; }

        [Display(Name = "Credits")]
        [Range(0, int.MaxValue, ErrorMessage = "No válido")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public int Credits { get; set; }

        public CourseViewModel(){}
        public CourseViewModel(Course c) {
            this.Id = c.CourseId;
            this.Title = c.Title;
            this.Credits = c.Credits;
        }

    }
}
