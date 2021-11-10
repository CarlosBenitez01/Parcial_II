using Microsoft.EntityFrameworkCore;
using PracticaSegundoParcial_CFBQ.Data;
using PracticaSegundoParcial_CFBQ.Dominio;
using PracticaSegundoParcial_CFBQ.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSegundoParcial_CFBQ.Repository
{
    public class EnrollementsRepository : IEnrollements
    {
        private AplicattionDbContext app;
        public EnrollementsRepository(AplicattionDbContext app)
        {
            this.app = app;
        }
        public IEnumerable<Enrollements> ListOfEnrollements()
        {
            return app.Enrollements.ToList();
        }

        public void InsertEnrollements(Enrollements e)
        {
            app.Add(e);
            app.SaveChanges();
        }
        public Enrollements RegistryFindById(int id)
        {
            Enrollements OneRegistry = app.Enrollements.Find(id);
            return OneRegistry;
        }
        public Enrollements RegistryFindByName(String name)
        {
            Enrollements OneRegistry = app.Enrollements.Find(name);
            return OneRegistry;
        }
        public List<Enrollements> UnionDeTablas()
        {
            var union = app.Enrollements.Include(e => e.Students).Include(c => c.Course).ToList();
            return union;

        }
    }
}
