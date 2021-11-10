using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSegundoParcial_CFBQ.Dominio
{
    public class Course
    {
        [Key] //atributo reconosca llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CourseId { get; set; } //llave primaria

        public string Title { get; set; }

        public int Credits { get; set; }

        //Hcer relacion con la tb enrollemen
        public ICollection<Enrollements> Enrollements { get; set; }
    }
}
