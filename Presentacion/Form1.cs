using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {

        private nCoordinador negocioCoordinador = new nCoordinador();
        private nSala negocioSala = new nSala();
        private nSolicitudEvento negocioSolicitudEvento = new nSolicitudEvento();
        public Form1()
        {
            InitializeComponent();
            CargarCoordinadores();
            CargarSalas();
        }

        private void CargarCoordinadores()
        {
            // Obtener la lista de coordinadores desde la capa de negocio
            List<Coordinador> listaCoordinadores = negocioCoordinador.ListarCoordinadores();
          
            cmbCoordinador.DataSource = listaCoordinadores;
            cmbCoordinador.DisplayMember = "NombreCompleto";
            cmbCoordinador.ValueMember = "CoordinadorId";
        }

        private void CargarSalas()
        {
            // Obtener la lista de salas desde la capa de negocio
            List<Sala> listaSalas = negocioSala.ListarSalas();

            cmbSala.DataSource = listaSalas;
            cmbSala.DisplayMember = "Nombre";
            cmbSala.ValueMember = "SalaId";
        }
        private void btnMostrarSolicitudesRegistradas_Click(object sender, EventArgs e)
        {
            // Obtener la lista de solicitudes desde la capa de negocio
            List<SolicitudEvento> listaSolicitudes = negocioSolicitudEvento.MostrarSolicitudesRegistradas();

            // Verificar si la lista tiene elementos
            if (listaSolicitudes == null || listaSolicitudes.Count == 0)
            {
                MessageBox.Show("No hay solicitudes registradas para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSolicitudes.DataSource = null;
                return;
            }

            // Crear el DataTable y definir las columnas
            DataTable dtSolicitudes = new DataTable();
            dtSolicitudes.Columns.Add("Id", typeof(int));
            dtSolicitudes.Columns.Add("TipoEvento", typeof(string));
            dtSolicitudes.Columns.Add("FechaHoraEvento", typeof(DateTime));
            dtSolicitudes.Columns.Add("CoordinadorId", typeof(int));
            dtSolicitudes.Columns.Add("SalaId", typeof(int));

            // Llenar el DataTable con los datos de la lista
            foreach (var solicitud in listaSolicitudes)
            {
                dtSolicitudes.Rows.Add(
                    solicitud.SolicitudEventoId,
                    solicitud.TipoEvento,
                    solicitud.FechaHoraEvento,
                    solicitud.CoordinadorId,
                    solicitud.SalaId
                );
            }

            // Asignar el DataTable al DataGridView
            dgvSolicitudes.DataSource = dtSolicitudes;
            dgvSolicitudes.AutoResizeColumns();
        }

        private void btnRegistrarSolicitud_Click(object sender, EventArgs e)
        {
            // Validar que la fecha del evento no sea menor a la actual
            if (dtFechaEvento.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha y hora del evento no puede ser menor a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear la nueva solicitud
            var nuevaSolicitud = new SolicitudEvento
            {
                TipoEvento = tbTipoEvento.Text,
                FechaHoraEvento = dtFechaEvento.Value,
                FechaRegistro = DateTime.Now,
                Confirmado = false,
                CoordinadorId = (int)cmbCoordinador.SelectedValue,
                SalaId = (int)cmbSala.SelectedValue
            };

            // Registrar la solicitud
            bool exito = negocioSolicitudEvento.RegistrarSolicitudEvento(nuevaSolicitud);
            if (exito)
                MessageBox.Show("Solicitud registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error al registrar la solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }




        private void btnModificarSolicitudRegistrada_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una solicitud para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int solicitudId = Convert.ToInt32(dgvSolicitudes.CurrentRow.Cells["Id"].Value);

            // Buscar la solicitud seleccionada
            var listaSolicitudes = negocioSolicitudEvento.MostrarSolicitudesRegistradas();
            var solicitud = listaSolicitudes.FirstOrDefault(s => s.SolicitudEventoId == solicitudId);

            if (solicitud == null)
            {
                MessageBox.Show("No se encontró la solicitud seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (solicitud.Confirmado)
            {
                MessageBox.Show("No se puede modificar una solicitud confirmada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Validar que la fecha del evento no sea menor a la actual
            if (dtFechaEvento.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha y hora del evento no puede ser menor a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tipoEvento = tbTipoEvento.Text;
            DateTime fechaHoraEvento = dtFechaEvento.Value;
            int coordinadorId = (int)cmbCoordinador.SelectedValue;
            int salaId = (int)cmbSala.SelectedValue;

            bool exito = negocioSolicitudEvento.ModificarSolicitudEvento(solicitudId, tipoEvento, fechaHoraEvento, coordinadorId, salaId);

            if (exito)
                MessageBox.Show("Solicitud modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error al modificar la solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEliminarSolicitudRegistrada_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una solicitud para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int solicitudId = Convert.ToInt32(dgvSolicitudes.CurrentRow.Cells["Id"].Value);

            // Buscar la solicitud seleccionada
            var listaSolicitudes = negocioSolicitudEvento.MostrarSolicitudesRegistradas();
            var solicitud = listaSolicitudes.FirstOrDefault(s => s.SolicitudEventoId == solicitudId);

            if (solicitud == null)
            {
                MessageBox.Show("No se encontró la solicitud seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (solicitud.Confirmado)
            {
                MessageBox.Show("No se puede eliminar una solicitud confirmada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirmar eliminación con el usuario
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la solicitud seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes)
                return;

            // Eliminar la solicitud
            bool exito = negocioSolicitudEvento.EliminarSolicitudEvento(solicitudId, mensaje =>
            {
                // Esta función se usa para confirmar la eliminación, pero ya fue confirmada arriba
                return true;
            });

            if (exito)
            {
                MessageBox.Show("Solicitud eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Refrescar la lista de solicitudes
                btnMostrarSolicitudesRegistradas_Click(null, null);
            }
            else
            {
                MessageBox.Show("Error al eliminar la solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmarSolicitud_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una solicitud para confirmar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int solicitudId = Convert.ToInt32(dgvSolicitudes.CurrentRow.Cells["Id"].Value);

            // Buscar la solicitud seleccionada
            var listaSolicitudes = negocioSolicitudEvento.MostrarSolicitudesRegistradas();
            var solicitud = listaSolicitudes.FirstOrDefault(s => s.SolicitudEventoId == solicitudId);

            if (solicitud == null)
            {
                MessageBox.Show("No se encontró la solicitud seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (solicitud.Confirmado)
            {
                MessageBox.Show("La solicitud ya está confirmada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DateTime.Now < solicitud.FechaHoraEvento)
            {
                MessageBox.Show("No se puede confirmar la solicitud antes de la fecha y hora programadas del evento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool exito = negocioSolicitudEvento.ConfirmarSolicitudEvento(solicitudId);

            if (exito)
            {
                MessageBox.Show("Solicitud confirmada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Refrescar la lista de solicitudes
                btnMostrarSolicitudesRegistradas_Click(null, null);
            }
            else
            {
                MessageBox.Show("Error al confirmar la solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
