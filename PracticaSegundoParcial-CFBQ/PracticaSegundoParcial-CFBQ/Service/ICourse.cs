using PracticaSegundoParcial_CFBQ.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSegundoParcial_CFBQ.Service
{
    public interface ICourse
    {
        IEnumerable<Course> ListOfCourses();
        void InsertCourse(Course c);
        void UpdateCourse(Course c);
        Course RegistryFindById(int id);
    }
}
