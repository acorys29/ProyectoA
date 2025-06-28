using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class dSolicitudEvento
    {
        private BDEFEntities bdcontext = new BDEFEntities();
        public List<SolicitudEvento> MostrarSolicitudesRegistradas()
        {
            // Devuelve todas las solicitudes de evento que no están eliminadas
            return bdcontext.SolicitudEvento
                .Where(se => !se.Eliminado)
                .ToList();
        }
        public bool RegistrarSolicitudEvento(SolicitudEvento nuevaSolicitud)
        {
            if (nuevaSolicitud == null)
                throw new ArgumentNullException(nameof(nuevaSolicitud));

            // Validar que la fecha del evento no sea menor a la fecha actual
            if (nuevaSolicitud.FechaHoraEvento < DateTime.Now)
                return false;

            nuevaSolicitud.FechaRegistro = DateTime.Now;
            nuevaSolicitud.Confirmado = false;
            nuevaSolicitud.Eliminado = false;

            bdcontext.SolicitudEvento.Add(nuevaSolicitud);
            bdcontext.SaveChanges();
            return true;
        }
        public bool ModificarSolicitudEvento(int solicitudEventoId, string tipoEvento, DateTime fechaHoraEvento, int coordinadorId, int salaId)
        {
            var solicitud = bdcontext.SolicitudEvento.FirstOrDefault(se => se.SolicitudEventoId == solicitudEventoId && !se.Eliminado);
            if (solicitud == null)
                return false;

            if (solicitud.Confirmado)
                return false;

            solicitud.TipoEvento = tipoEvento;
            solicitud.FechaHoraEvento = fechaHoraEvento;
            solicitud.CoordinadorId = coordinadorId;
            solicitud.SalaId = salaId;

            bdcontext.SaveChanges();
            return true;
        }
        public bool EliminarSolicitudEvento(int solicitudEventoId, Func<string, bool> confirmarEliminacion)
        {
            var solicitud = bdcontext.SolicitudEvento.FirstOrDefault(se => se.SolicitudEventoId == solicitudEventoId && !se.Eliminado);
            if (solicitud == null)
                return false;

            if (solicitud.Confirmado)
                return false;

            // Preguntar al usuario si está seguro de eliminar el registro
            if (confirmarEliminacion == null || !confirmarEliminacion("¿Está seguro de que desea eliminar la solicitud seleccionada?"))
                return false;

            solicitud.Eliminado = true;
            bdcontext.SaveChanges();
            return true;
        }
        public bool ConfirmarSolicitudEvento(int solicitudEventoId, Action<string> mostrarAdvertencia)
        {
            var solicitud = bdcontext.SolicitudEvento.FirstOrDefault(se => se.SolicitudEventoId == solicitudEventoId && !se.Eliminado);
            if (solicitud == null)
                return false;

            if (solicitud.Confirmado)
                return true;

            if (DateTime.Now < solicitud.FechaHoraEvento)
            {
                mostrarAdvertencia?.Invoke("No se puede confirmar la solicitud antes de la fecha y hora programadas.");
                return false;
            }

            solicitud.Confirmado = true;
            bdcontext.SaveChanges();
            return true;
        }

        //
    }
}
