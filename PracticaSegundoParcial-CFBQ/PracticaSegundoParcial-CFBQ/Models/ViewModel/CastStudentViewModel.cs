using PracticaSegundoParcial_CFBQ.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSegundoParcial_CFBQ.Models.ViewModel
{
    public class CastStudentViewModel
    {
        public String LastName { get; set; }
        public String FirstMidName { get; set; }
        public DateTime EnrollementsDate { get; set; }
        public CastStudentViewModel()
        {

        }
        public CastStudentViewModel(Students s)
        {
            this.LastName = s.LastName;
            this.FirstMidName = s.FirtsMidName;
            this.EnrollementsDate = s.EnrollementsDate;
        }
    }
}
