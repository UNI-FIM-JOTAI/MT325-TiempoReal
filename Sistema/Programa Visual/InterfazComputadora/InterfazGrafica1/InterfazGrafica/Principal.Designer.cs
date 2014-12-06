namespace InterfazGrafica
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.PuertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.BtnCalendarizacion = new System.Windows.Forms.PictureBox();
            this.BtnCargaDescarga = new System.Windows.Forms.Button();
            this.BtnVersion = new System.Windows.Forms.Button();
            this.BtnAdmProcesos = new System.Windows.Forms.Button();
            this.Calendarizacion = new System.Windows.Forms.Label();
            this.AdmProcesos = new System.Windows.Forms.Label();
            this.CargaDescarga = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.BtnTerminal = new System.Windows.Forms.PictureBox();
            this.Terminal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCalendarizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnTerminal)).BeginInit();
            this.SuspendLayout();
            // 
            // PuertoSerial
            // 
            this.PuertoSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerial_DataReceived);
            // 
            // BtnCalendarizacion
            // 
            this.BtnCalendarizacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCalendarizacion.BackgroundImage")));
            this.BtnCalendarizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCalendarizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalendarizacion.Location = new System.Drawing.Point(57, 64);
            this.BtnCalendarizacion.Name = "BtnCalendarizacion";
            this.BtnCalendarizacion.Size = new System.Drawing.Size(85, 75);
            this.BtnCalendarizacion.TabIndex = 2;
            this.BtnCalendarizacion.TabStop = false;
            this.BtnCalendarizacion.Click += new System.EventHandler(this.BtnCalendarizacion_Click);
            // 
            // BtnCargaDescarga
            // 
            this.BtnCargaDescarga.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCargaDescarga.BackgroundImage")));
            this.BtnCargaDescarga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCargaDescarga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCargaDescarga.Location = new System.Drawing.Point(207, 64);
            this.BtnCargaDescarga.Name = "BtnCargaDescarga";
            this.BtnCargaDescarga.Size = new System.Drawing.Size(85, 75);
            this.BtnCargaDescarga.TabIndex = 3;
            this.BtnCargaDescarga.UseVisualStyleBackColor = true;
            this.BtnCargaDescarga.Click += new System.EventHandler(this.BtnCargaDescarga_Click);
            // 
            // BtnVersion
            // 
            this.BtnVersion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVersion.BackgroundImage")));
            this.BtnVersion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVersion.Location = new System.Drawing.Point(57, 177);
            this.BtnVersion.Name = "BtnVersion";
            this.BtnVersion.Size = new System.Drawing.Size(85, 75);
            this.BtnVersion.TabIndex = 4;
            this.BtnVersion.UseVisualStyleBackColor = true;
            // 
            // BtnAdmProcesos
            // 
            this.BtnAdmProcesos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdmProcesos.BackgroundImage")));
            this.BtnAdmProcesos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdmProcesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdmProcesos.Location = new System.Drawing.Point(207, 177);
            this.BtnAdmProcesos.Name = "BtnAdmProcesos";
            this.BtnAdmProcesos.Size = new System.Drawing.Size(85, 75);
            this.BtnAdmProcesos.TabIndex = 5;
            this.BtnAdmProcesos.UseVisualStyleBackColor = true;
            this.BtnAdmProcesos.Click += new System.EventHandler(this.BtnAdmProcesos_Click);
            // 
            // Calendarizacion
            // 
            this.Calendarizacion.AutoSize = true;
            this.Calendarizacion.BackColor = System.Drawing.Color.Transparent;
            this.Calendarizacion.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendarizacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Calendarizacion.Location = new System.Drawing.Point(41, 42);
            this.Calendarizacion.Name = "Calendarizacion";
            this.Calendarizacion.Size = new System.Drawing.Size(115, 19);
            this.Calendarizacion.TabIndex = 6;
            this.Calendarizacion.Text = "Calendarización";
            // 
            // AdmProcesos
            // 
            this.AdmProcesos.AutoSize = true;
            this.AdmProcesos.BackColor = System.Drawing.Color.Transparent;
            this.AdmProcesos.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmProcesos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdmProcesos.Location = new System.Drawing.Point(199, 155);
            this.AdmProcesos.Name = "AdmProcesos";
            this.AdmProcesos.Size = new System.Drawing.Size(106, 19);
            this.AdmProcesos.TabIndex = 7;
            this.AdmProcesos.Text = "Adm. Procesos";
            this.AdmProcesos.Click += new System.EventHandler(this.label2_Click);
            // 
            // CargaDescarga
            // 
            this.CargaDescarga.AutoSize = true;
            this.CargaDescarga.BackColor = System.Drawing.Color.Transparent;
            this.CargaDescarga.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargaDescarga.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CargaDescarga.Location = new System.Drawing.Point(190, 42);
            this.CargaDescarga.Name = "CargaDescarga";
            this.CargaDescarga.Size = new System.Drawing.Size(127, 19);
            this.CargaDescarga.TabIndex = 8;
            this.CargaDescarga.Text = "Carga y Descarga";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Version.Location = new System.Drawing.Point(70, 155);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(59, 19);
            this.Version.TabIndex = 9;
            this.Version.Text = "Version";
            // 
            // BtnTerminal
            // 
            this.BtnTerminal.BackColor = System.Drawing.Color.Transparent;
            this.BtnTerminal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnTerminal.BackgroundImage")));
            this.BtnTerminal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTerminal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTerminal.Location = new System.Drawing.Point(351, 64);
            this.BtnTerminal.Name = "BtnTerminal";
            this.BtnTerminal.Size = new System.Drawing.Size(85, 75);
            this.BtnTerminal.TabIndex = 10;
            this.BtnTerminal.TabStop = false;
            this.BtnTerminal.Click += new System.EventHandler(this.BtnTerminal_Click);
            // 
            // Terminal
            // 
            this.Terminal.AutoSize = true;
            this.Terminal.BackColor = System.Drawing.Color.Transparent;
            this.Terminal.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Terminal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Terminal.Location = new System.Drawing.Point(336, 42);
            this.Terminal.Name = "Terminal";
            this.Terminal.Size = new System.Drawing.Size(119, 19);
            this.Terminal.TabIndex = 11;
            this.Terminal.Text = "Virtual Terminal";
            this.Terminal.Click += new System.EventHandler(this.Terminal_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 310);
            this.Controls.Add(this.Terminal);
            this.Controls.Add(this.BtnTerminal);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.CargaDescarga);
            this.Controls.Add(this.AdmProcesos);
            this.Controls.Add(this.Calendarizacion);
            this.Controls.Add(this.BtnAdmProcesos);
            this.Controls.Add(this.BtnVersion);
            this.Controls.Add(this.BtnCargaDescarga);
            this.Controls.Add(this.BtnCalendarizacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "InterfazGrafica";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCalendarizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnTerminal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort PuertoSerial;
        private System.Windows.Forms.PictureBox BtnCalendarizacion;
        private System.Windows.Forms.Button BtnCargaDescarga;
        private System.Windows.Forms.Button BtnVersion;
        private System.Windows.Forms.Button BtnAdmProcesos;
        private System.Windows.Forms.Label Calendarizacion;
        private System.Windows.Forms.Label AdmProcesos;
        private System.Windows.Forms.Label CargaDescarga;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.PictureBox BtnTerminal;
        private System.Windows.Forms.Label Terminal;
    }
}

