using PracticaSegundoParcial_CFBQ.Data;
using PracticaSegundoParcial_CFBQ.Dominio;
using PracticaSegundoParcial_CFBQ.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSegundoParcial_CFBQ.Repository
{
    public class StudentsRepository : IStudents
    {
        private AplicattionDbContext app;
        public StudentsRepository(AplicattionDbContext app)
        {
            this.app = app;
        }
        public IEnumerable<Students> ListOfStudents()
        {
            return app.Students.ToList();
        }

        public void InsertStudent(Students s)
        {
            app.Add(s);
            app.SaveChanges();
        }
        public void UpdateStudent(Students s)
        {
            app.Update(s);
            app.SaveChanges();
        }
        public Students RegistryFindById(int id)
        {
            Students OneRegistry = app.Students.Find(id);
            return OneRegistry;
        }
    }
}

