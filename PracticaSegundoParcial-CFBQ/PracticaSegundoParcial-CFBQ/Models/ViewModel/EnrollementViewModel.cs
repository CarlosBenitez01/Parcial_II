using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSegundoParcial_CFBQ.Models.ViewModel
{
    public class EnrollementViewModel
    {
        [Display(Name = "CourseID")]
        public int CourseID { get; set; }

        [Display(Name = "StudentsID")]
        public int StudentsID { get; set; }

        [Display(Name = "Grade")]
        public int Grade { get; set; }

    }
}
