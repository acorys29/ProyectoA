using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class nCoordinador
    {
        private dCoordinador datosCoordinador = new dCoordinador();

        
        public List<Coordinador> ListarCoordinadores()
        {
            return datosCoordinador.ListarCoordinadores();
        }

    }
}
