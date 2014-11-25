namespace InterfazGrafica
{
    partial class CargaDescarga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargaDescarga));
            this.GBx_Proceso3 = new System.Windows.Forms.GroupBox();
            this.Btn_Cargar3 = new System.Windows.Forms.Button();
            this.GBx_Proceso1 = new System.Windows.Forms.GroupBox();
            this.Btn_Descargar1 = new System.Windows.Forms.Button();
            this.Btn_Cargar1 = new System.Windows.Forms.Button();
            this.GBx_Proceso2 = new System.Windows.Forms.GroupBox();
            this.Btn_Descargar2 = new System.Windows.Forms.Button();
            this.Btn_Cargar2 = new System.Windows.Forms.Button();
            this.GBx_Proceso4 = new System.Windows.Forms.GroupBox();
            this.Btn_Cargar4 = new System.Windows.Forms.Button();
            this.BtnConexion = new System.Windows.Forms.Button();
            this.PuertoList = new System.Windows.Forms.ComboBox();
            this.PuertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.GBx_Proceso3.SuspendLayout();
            this.GBx_Proceso1.SuspendLayout();
            this.GBx_Proceso2.SuspendLayout();
            this.GBx_Proceso4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBx_Proceso3
            // 
            this.GBx_Proceso3.BackColor = System.Drawing.Color.Transparent;
            this.GBx_Proceso3.Controls.Add(this.Btn_Cargar3);
            this.GBx_Proceso3.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBx_Proceso3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBx_Proceso3.Location = new System.Drawing.Point(211, 128);
            this.GBx_Proceso3.Name = "GBx_Proceso3";
            this.GBx_Proceso3.Size = new System.Drawing.Size(102, 80);
            this.GBx_Proceso3.TabIndex = 0;
            this.GBx_Proceso3.TabStop = false;
            this.GBx_Proceso3.Text = "Proceso 3";
            // 
            // Btn_Cargar3
            // 
            this.Btn_Cargar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Cargar3.BackgroundImage")));
            this.Btn_Cargar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cargar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cargar3.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Cargar3.Location = new System.Drawing.Point(27, 23);
            this.Btn_Cargar3.Name = "Btn_Cargar3";
            this.Btn_Cargar3.Size = new System.Drawing.Size(49, 45);
            this.Btn_Cargar3.TabIndex = 0;
            this.Btn_Cargar3.UseVisualStyleBackColor = true;
            this.Btn_Cargar3.Click += new System.EventHandler(this.Btn_Cargar3_Click);
            // 
            // GBx_Proceso1
            // 
            this.GBx_Proceso1.BackColor = System.Drawing.Color.Transparent;
            this.GBx_Proceso1.Controls.Add(this.Btn_Descargar1);
            this.GBx_Proceso1.Controls.Add(this.Btn_Cargar1);
            this.GBx_Proceso1.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBx_Proceso1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBx_Proceso1.Location = new System.Drawing.Point(193, 33);
            this.GBx_Proceso1.Name = "GBx_Proceso1";
            this.GBx_Proceso1.Size = new System.Drawing.Size(139, 80);
            this.GBx_Proceso1.TabIndex = 2;
            this.GBx_Proceso1.TabStop = false;
            this.GBx_Proceso1.Text = "Proceso 1";
            // 
            // Btn_Descargar1
            // 
            this.Btn_Descargar1.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Descargar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Descargar1.BackgroundImage")));
            this.Btn_Descargar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Descargar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Descargar1.Location = new System.Drawing.Point(73, 23);
            this.Btn_Descargar1.Name = "Btn_Descargar1";
            this.Btn_Descargar1.Size = new System.Drawing.Size(49, 45);
            this.Btn_Descargar1.TabIndex = 1;
            this.Btn_Descargar1.UseVisualStyleBackColor = false;
            this.Btn_Descargar1.Click += new System.EventHandler(this.Btn_Descargar1_Click);
            // 
            // Btn_Cargar1
            // 
            this.Btn_Cargar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Cargar1.BackgroundImage")));
            this.Btn_Cargar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cargar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cargar1.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Cargar1.Location = new System.Drawing.Point(18, 23);
            this.Btn_Cargar1.Name = "Btn_Cargar1";
            this.Btn_Cargar1.Size = new System.Drawing.Size(49, 45);
            this.Btn_Cargar1.TabIndex = 0;
            this.Btn_Cargar1.UseVisualStyleBackColor = true;
            this.Btn_Cargar1.Click += new System.EventHandler(this.Btn_Cargar1_Click);
            // 
            // GBx_Proceso2
            // 
            this.GBx_Proceso2.BackColor = System.Drawing.Color.Transparent;
            this.GBx_Proceso2.Controls.Add(this.Btn_Descargar2);
            this.GBx_Proceso2.Controls.Add(this.Btn_Cargar2);
            this.GBx_Proceso2.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBx_Proceso2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBx_Proceso2.Location = new System.Drawing.Point(355, 33);
            this.GBx_Proceso2.Name = "GBx_Proceso2";
            this.GBx_Proceso2.Size = new System.Drawing.Size(139, 80);
            this.GBx_Proceso2.TabIndex = 3;
            this.GBx_Proceso2.TabStop = false;
            this.GBx_Proceso2.Text = "Proceso 2";
            // 
            // Btn_Descargar2
            // 
            this.Btn_Descargar2.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Descargar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Descargar2.BackgroundImage")));
            this.Btn_Descargar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Descargar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Descargar2.Location = new System.Drawing.Point(73, 23);
            this.Btn_Descargar2.Name = "Btn_Descargar2";
            this.Btn_Descargar2.Size = new System.Drawing.Size(49, 45);
            this.Btn_Descargar2.TabIndex = 1;
            this.Btn_Descargar2.UseVisualStyleBackColor = false;
            this.Btn_Descargar2.Click += new System.EventHandler(this.Btn_Descargar2_Click);
            // 
            // Btn_Cargar2
            // 
            this.Btn_Cargar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Cargar2.BackgroundImage")));
            this.Btn_Cargar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cargar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cargar2.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Cargar2.Location = new System.Drawing.Point(18, 23);
            this.Btn_Cargar2.Name = "Btn_Cargar2";
            this.Btn_Cargar2.Size = new System.Drawing.Size(49, 45);
            this.Btn_Cargar2.TabIndex = 0;
            this.Btn_Cargar2.UseVisualStyleBackColor = true;
            this.Btn_Cargar2.Click += new System.EventHandler(this.Btn_Cargar2_Click);
            // 
            // GBx_Proceso4
            // 
            this.GBx_Proceso4.BackColor = System.Drawing.Color.Transparent;
            this.GBx_Proceso4.Controls.Add(this.Btn_Cargar4);
            this.GBx_Proceso4.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBx_Proceso4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBx_Proceso4.Location = new System.Drawing.Point(374, 128);
            this.GBx_Proceso4.Name = "GBx_Proceso4";
            this.GBx_Proceso4.Size = new System.Drawing.Size(101, 80);
            this.GBx_Proceso4.TabIndex = 2;
            this.GBx_Proceso4.TabStop = false;
            this.GBx_Proceso4.Text = "Proceso 4";
            // 
            // Btn_Cargar4
            // 
            this.Btn_Cargar4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Cargar4.BackgroundImage")));
            this.Btn_Cargar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cargar4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cargar4.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Cargar4.Location = new System.Drawing.Point(27, 23);
            this.Btn_Cargar4.Name = "Btn_Cargar4";
            this.Btn_Cargar4.Size = new System.Drawing.Size(49, 45);
            this.Btn_Cargar4.TabIndex = 0;
            this.Btn_Cargar4.UseVisualStyleBackColor = true;
            this.Btn_Cargar4.Click += new System.EventHandler(this.Btn_Cargar4_Click);
            // 
            // BtnConexion
            // 
            this.BtnConexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConexion.BackgroundImage")));
            this.BtnConexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConexion.Location = new System.Drawing.Point(64, 33);
            this.BtnConexion.Name = "BtnConexion";
            this.BtnConexion.Size = new System.Drawing.Size(68, 61);
            this.BtnConexion.TabIndex = 5;
            this.BtnConexion.UseVisualStyleBackColor = true;
            this.BtnConexion.Click += new System.EventHandler(this.BtnConexion_Click);
            // 
            // PuertoList
            // 
            this.PuertoList.FormattingEnabled = true;
            this.PuertoList.Location = new System.Drawing.Point(51, 100);
            this.PuertoList.Name = "PuertoList";
            this.PuertoList.Size = new System.Drawing.Size(94, 21);
            this.PuertoList.TabIndex = 4;
            // 
            // PuertoSerial
            // 
            this.PuertoSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerial_DataReceived);
            // 
            // CargaDescarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 259);
            this.Controls.Add(this.BtnConexion);
            this.Controls.Add(this.PuertoList);
            this.Controls.Add(this.GBx_Proceso4);
            this.Controls.Add(this.GBx_Proceso2);
            this.Controls.Add(this.GBx_Proceso1);
            this.Controls.Add(this.GBx_Proceso3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CargaDescarga";
            this.Text = "CargaDescarga";
            this.Load += new System.EventHandler(this.CargaDescarga_Load);
            this.GBx_Proceso3.ResumeLayout(false);
            this.GBx_Proceso1.ResumeLayout(false);
            this.GBx_Proceso2.ResumeLayout(false);
            this.GBx_Proceso4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBx_Proceso3;
        private System.Windows.Forms.GroupBox GBx_Proceso1;
        private System.Windows.Forms.Button Btn_Descargar1;
        private System.Windows.Forms.Button Btn_Cargar1;
        private System.Windows.Forms.Button Btn_Cargar3;
        private System.Windows.Forms.GroupBox GBx_Proceso2;
        private System.Windows.Forms.Button Btn_Descargar2;
        private System.Windows.Forms.Button Btn_Cargar2;
        private System.Windows.Forms.GroupBox GBx_Proceso4;
        private System.Windows.Forms.Button Btn_Cargar4;
        private System.Windows.Forms.Button BtnConexion;
        private System.Windows.Forms.ComboBox PuertoList;
        private System.IO.Ports.SerialPort PuertoSerial;
    }
}