using PracticaSegundoParcial_CFBQ.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSegundoParcial_CFBQ.Service
{
    public interface IEnrollements
    {
        IEnumerable<Enrollements> ListOfEnrollements();
        void InsertEnrollements(Enrollements e);
        Enrollements RegistryFindById(int id);
        Enrollements RegistryFindByName(String name);
        List<Enrollements> UnionDeTablas();
    }
}
