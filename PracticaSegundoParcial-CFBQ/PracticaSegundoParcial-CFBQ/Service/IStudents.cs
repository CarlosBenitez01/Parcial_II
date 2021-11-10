using PracticaSegundoParcial_CFBQ.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSegundoParcial_CFBQ.Service
{
    public interface IStudents
    {
        IEnumerable<Students> ListOfStudents();

        void InsertStudent(Students s);
        void UpdateStudent(Students s);
        Students RegistryFindById(int id);
    }
}
