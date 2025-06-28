using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class dSala
    {
        private BDEFEntities bdcontext = new BDEFEntities();
        public List<Sala> ListarSalas()
        {
            return bdcontext.Sala.Where(s => !s.Eliminado).ToList();
        }

        //
    }
}
