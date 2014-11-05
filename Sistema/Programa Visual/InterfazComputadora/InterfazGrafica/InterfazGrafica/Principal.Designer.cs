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
            this.PuertoList = new System.Windows.Forms.ComboBox();
            this.BtnConexion = new System.Windows.Forms.Button();
            this.PuertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.BtnCalendarizacion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCalendarizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // PuertoList
            // 
            this.PuertoList.FormattingEnabled = true;
            this.PuertoList.Location = new System.Drawing.Point(21, 79);
            this.PuertoList.Name = "PuertoList";
            this.PuertoList.Size = new System.Drawing.Size(94, 21);
            this.PuertoList.TabIndex = 0;
            this.PuertoList.SelectedIndexChanged += new System.EventHandler(this.PuertoList_SelectedIndexChanged);
            // 
            // BtnConexion
            // 
            this.BtnConexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConexion.BackgroundImage")));
            this.BtnConexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConexion.Location = new System.Drawing.Point(34, 12);
            this.BtnConexion.Name = "BtnConexion";
            this.BtnConexion.Size = new System.Drawing.Size(68, 61);
            this.BtnConexion.TabIndex = 1;
            this.BtnConexion.UseVisualStyleBackColor = true;
            this.BtnConexion.Click += new System.EventHandler(this.BtnConexion_Click);
            // 
            // BtnCalendarizacion
            // 
            this.BtnCalendarizacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCalendarizacion.BackgroundImage")));
            this.BtnCalendarizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCalendarizacion.Location = new System.Drawing.Point(166, 23);
            this.BtnCalendarizacion.Name = "BtnCalendarizacion";
            this.BtnCalendarizacion.Size = new System.Drawing.Size(83, 77);
            this.BtnCalendarizacion.TabIndex = 2;
            this.BtnCalendarizacion.TabStop = false;
            this.BtnCalendarizacion.Click += new System.EventHandler(this.BtnCalendarizacion_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 388);
            this.Controls.Add(this.BtnCalendarizacion);
            this.Controls.Add(this.BtnConexion);
            this.Controls.Add(this.PuertoList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "InterfazGrafica";
            ((System.ComponentModel.ISupportInitialize)(this.BtnCalendarizacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PuertoList;
        private System.Windows.Forms.Button BtnConexion;
        private System.IO.Ports.SerialPort PuertoSerial;
        private System.Windows.Forms.PictureBox BtnCalendarizacion;
    }
}

