using PrograIILaboratorioII.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrograIILaboratorioII.Service
{
    public interface IPersona
    {

        void Save(Persona E);
            ICollection<Persona>Listardatos();
        
    }
}
