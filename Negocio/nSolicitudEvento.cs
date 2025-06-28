using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class nSolicitudEvento
    {
        private dSolicitudEvento datosSolicitudEvento = new dSolicitudEvento();

        public List<SolicitudEvento> MostrarSolicitudesRegistradas()
        {
            return datosSolicitudEvento.MostrarSolicitudesRegistradas();
        }

        public bool RegistrarSolicitudEvento(SolicitudEvento nuevaSolicitud)
        {
            return datosSolicitudEvento.RegistrarSolicitudEvento(nuevaSolicitud);
        }

        public bool ModificarSolicitudEvento(int solicitudEventoId, string tipoEvento, DateTime fechaHoraEvento, int coordinadorId, int salaId)
        {
            return datosSolicitudEvento.ModificarSolicitudEvento(solicitudEventoId, tipoEvento, fechaHoraEvento, coordinadorId, salaId);
        }

        public bool EliminarSolicitudEvento(int solicitudEventoId, Func<string, bool> confirmarEliminacion)
        {
            return datosSolicitudEvento.EliminarSolicitudEvento(solicitudEventoId, confirmarEliminacion);
        }

        public bool ConfirmarSolicitudEvento(int solicitudEventoId)
        {
            Action<string> mostrarAdvertencia = mensaje => Console.WriteLine(mensaje);
            return datosSolicitudEvento.ConfirmarSolicitudEvento(solicitudEventoId, mostrarAdvertencia);
        }
    }
}
