namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrarSolicitudesRegistradas = new System.Windows.Forms.Button();
            this.btnRegistrarSolicitud = new System.Windows.Forms.Button();
            this.btnModificarSolicitudRegistrada = new System.Windows.Forms.Button();
            this.btnEliminarSolicitudRegistrada = new System.Windows.Forms.Button();
            this.btnConfirmarSolicitud = new System.Windows.Forms.Button();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTipoEvento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFechaEvento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCoordinador = new System.Windows.Forms.ComboBox();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarSolicitudesRegistradas
            // 
            this.btnMostrarSolicitudesRegistradas.Location = new System.Drawing.Point(28, 30);
            this.btnMostrarSolicitudesRegistradas.Name = "btnMostrarSolicitudesRegistradas";
            this.btnMostrarSolicitudesRegistradas.Size = new System.Drawing.Size(134, 52);
            this.btnMostrarSolicitudesRegistradas.TabIndex = 0;
            this.btnMostrarSolicitudesRegistradas.Text = "Mostrar Solicitudes Registradas";
            this.btnMostrarSolicitudesRegistradas.UseVisualStyleBackColor = true;
            this.btnMostrarSolicitudesRegistradas.Click += new System.EventHandler(this.btnMostrarSolicitudesRegistradas_Click);
            // 
            // btnRegistrarSolicitud
            // 
            this.btnRegistrarSolicitud.Location = new System.Drawing.Point(28, 88);
            this.btnRegistrarSolicitud.Name = "btnRegistrarSolicitud";
            this.btnRegistrarSolicitud.Size = new System.Drawing.Size(134, 49);
            this.btnRegistrarSolicitud.TabIndex = 1;
            this.btnRegistrarSolicitud.Text = "Registrar Solicitud";
            this.btnRegistrarSolicitud.UseVisualStyleBackColor = true;
            this.btnRegistrarSolicitud.Click += new System.EventHandler(this.btnRegistrarSolicitud_Click);
            // 
            // btnModificarSolicitudRegistrada
            // 
            this.btnModificarSolicitudRegistrada.Location = new System.Drawing.Point(28, 153);
            this.btnModificarSolicitudRegistrada.Name = "btnModificarSolicitudRegistrada";
            this.btnModificarSolicitudRegistrada.Size = new System.Drawing.Size(134, 64);
            this.btnModificarSolicitudRegistrada.TabIndex = 2;
            this.btnModificarSolicitudRegistrada.Text = "Modificar Solicitud Registrada";
            this.btnModificarSolicitudRegistrada.UseVisualStyleBackColor = true;
            this.btnModificarSolicitudRegistrada.Click += new System.EventHandler(this.btnModificarSolicitudRegistrada_Click);
            // 
            // btnEliminarSolicitudRegistrada
            // 
            this.btnEliminarSolicitudRegistrada.Location = new System.Drawing.Point(28, 238);
            this.btnEliminarSolicitudRegistrada.Name = "btnEliminarSolicitudRegistrada";
            this.btnEliminarSolicitudRegistrada.Size = new System.Drawing.Size(134, 56);
            this.btnEliminarSolicitudRegistrada.TabIndex = 3;
            this.btnEliminarSolicitudRegistrada.Text = "Eliminar Solicitud Registrada";
            this.btnEliminarSolicitudRegistrada.UseVisualStyleBackColor = true;
            this.btnEliminarSolicitudRegistrada.Click += new System.EventHandler(this.btnEliminarSolicitudRegistrada_Click);
            // 
            // btnConfirmarSolicitud
            // 
            this.btnConfirmarSolicitud.Location = new System.Drawing.Point(28, 314);
            this.btnConfirmarSolicitud.Name = "btnConfirmarSolicitud";
            this.btnConfirmarSolicitud.Size = new System.Drawing.Size(134, 61);
            this.btnConfirmarSolicitud.TabIndex = 4;
            this.btnConfirmarSolicitud.Text = "Confirmar Solicitud";
            this.btnConfirmarSolicitud.UseVisualStyleBackColor = true;
            this.btnConfirmarSolicitud.Click += new System.EventHandler(this.btnConfirmarSolicitud_Click);
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Location = new System.Drawing.Point(241, 209);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.RowHeadersWidth = 51;
            this.dgvSolicitudes.RowTemplate.Height = 24;
            this.dgvSolicitudes.Size = new System.Drawing.Size(525, 203);
            this.dgvSolicitudes.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo Evento:";
            // 
            // tbTipoEvento
            // 
            this.tbTipoEvento.Location = new System.Drawing.Point(364, 27);
            this.tbTipoEvento.Name = "tbTipoEvento";
            this.tbTipoEvento.Size = new System.Drawing.Size(121, 22);
            this.tbTipoEvento.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha del evento:";
            // 
            // dtFechaEvento
            // 
            this.dtFechaEvento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaEvento.Location = new System.Drawing.Point(364, 66);
            this.dtFechaEvento.Name = "dtFechaEvento";
            this.dtFechaEvento.Size = new System.Drawing.Size(121, 22);
            this.dtFechaEvento.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Coordinador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sala:";
            // 
            // cmbCoordinador
            // 
            this.cmbCoordinador.FormattingEnabled = true;
            this.cmbCoordinador.Location = new System.Drawing.Point(364, 101);
            this.cmbCoordinador.Name = "cmbCoordinador";
            this.cmbCoordinador.Size = new System.Drawing.Size(121, 24);
            this.cmbCoordinador.TabIndex = 12;
            // 
            // cmbSala
            // 
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(364, 137);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(121, 24);
            this.cmbSala.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbSala);
            this.Controls.Add(this.cmbCoordinador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFechaEvento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTipoEvento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSolicitudes);
            this.Controls.Add(this.btnConfirmarSolicitud);
            this.Controls.Add(this.btnEliminarSolicitudRegistrada);
            this.Controls.Add(this.btnModificarSolicitudRegistrada);
            this.Controls.Add(this.btnRegistrarSolicitud);
            this.Controls.Add(this.btnMostrarSolicitudesRegistradas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarSolicitudesRegistradas;
        private System.Windows.Forms.Button btnRegistrarSolicitud;
        private System.Windows.Forms.Button btnModificarSolicitudRegistrada;
        private System.Windows.Forms.Button btnEliminarSolicitudRegistrada;
        private System.Windows.Forms.Button btnConfirmarSolicitud;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTipoEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFechaEvento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCoordinador;
        private System.Windows.Forms.ComboBox cmbSala;
    }
}

