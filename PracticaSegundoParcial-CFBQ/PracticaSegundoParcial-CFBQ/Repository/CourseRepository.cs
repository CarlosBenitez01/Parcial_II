using PracticaSegundoParcial_CFBQ.Data;
using PracticaSegundoParcial_CFBQ.Dominio;
using PracticaSegundoParcial_CFBQ.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSegundoParcial_CFBQ.Repository
{
    public class CourseRepository : ICourse
    {
        private AplicattionDbContext app;
        public CourseRepository(AplicattionDbContext app)
        {
            this.app = app;
        }
        public IEnumerable<Course> ListOfCourses()
        {
            return app.Courses.ToList();
        }

        public void InsertCourse(Course c)
        {
            app.Add(c);
            app.SaveChanges();
        }
        public void UpdateCourse(Course c)
        {
            app.Update(c);
            app.SaveChanges();
        }
        public Course RegistryFindById(int id)
        {
            Course OneRegistry = app.Courses.Find(id);
            return OneRegistry;
        }
        public Course RegistryFindByName(String name)
        {
            Course OneRegistry = app.Courses.Find(name);
            return OneRegistry;
        }
    }
}
