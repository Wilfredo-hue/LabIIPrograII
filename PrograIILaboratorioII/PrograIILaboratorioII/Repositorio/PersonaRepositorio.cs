using PrograIILaboratorioII.Repositorio;
using PrograIILaboratorioII.Controllers.Data;
using PrograIILaboratorioII.Dominio;
using PrograIILaboratorioII.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrograIILaboratorioII.Repositorio
{
    interface PersonaRepositorio : IPersona
    {
        private ApplicationDBContext app;

        public PersonaRepositorio(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void save(Persona E)
        {
            app.Add(E);
            app.SaveChanges();
        }
    }
}
