using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class dCoordinador
    {
        private BDEFEntities bdcontext = new BDEFEntities();
        public List<Coordinador> ListarCoordinadores()
        {
            return bdcontext.Coordinador
                .Where(c => !c.Eliminado)
                .OrderBy(c => c.NombreCompleto)
                .ToList();
        }

       
    }
}
