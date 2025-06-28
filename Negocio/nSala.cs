using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;    

namespace Negocio
{
    public class nSala
    {
        private dSala datosSala = new dSala();

        public List<Sala> ListarSalas()
        {
            return datosSala.ListarSalas();
        }
    }
}
