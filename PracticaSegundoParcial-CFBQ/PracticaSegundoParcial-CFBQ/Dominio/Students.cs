using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSegundoParcial_CFBQ.Dominio
{
    public class Students
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int StudentId { get; set; }

        public string LastName { get; set; }

        public string FirtsMidName { get; set; }

        public int Status { get; set; }

        public DateTime EnrollementsDate { get; set; }

        //Hcer relacion con la tb enrollements
        public ICollection<Enrollements> Enrollements { get; set; }
    }
}
