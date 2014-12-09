namespace InterfazGrafica
{
    partial class LecturaADC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturaADC));
            this.PBx_Monitor = new System.Windows.Forms.PictureBox();
            this.BtnVerGraficas = new System.Windows.Forms.PictureBox();
            this.LConexion = new System.Windows.Forms.Label();
            this.BtnConexion = new System.Windows.Forms.Button();
            this.PuertoList = new System.Windows.Forms.ComboBox();
            this.PuertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEjecutar = new System.Windows.Forms.PictureBox();
            this.BtnDetener = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBx_Monitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerGraficas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEjecutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDetener)).BeginInit();
            this.SuspendLayout();
            // 
            // PBx_Monitor
            // 
            this.PBx_Monitor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PBx_Monitor.Location = new System.Drawing.Point(12, 24);
            this.PBx_Monitor.Name = "PBx_Monitor";
            this.PBx_Monitor.Size = new System.Drawing.Size(450, 358);
            this.PBx_Monitor.TabIndex = 0;
            this.PBx_Monitor.TabStop = false;
            // 
            // BtnVerGraficas
            // 
            this.BtnVerGraficas.BackColor = System.Drawing.Color.Transparent;
            this.BtnVerGraficas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVerGraficas.BackgroundImage")));
            this.BtnVerGraficas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVerGraficas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerGraficas.Location = new System.Drawing.Point(528, 124);
            this.BtnVerGraficas.Name = "BtnVerGraficas";
            this.BtnVerGraficas.Size = new System.Drawing.Size(58, 60);
            this.BtnVerGraficas.TabIndex = 1;
            this.BtnVerGraficas.TabStop = false;
            this.BtnVerGraficas.Click += new System.EventHandler(this.BtnVerGraficas_Click);
            // 
            // LConexion
            // 
            this.LConexion.AutoSize = true;
            this.LConexion.BackColor = System.Drawing.Color.Transparent;
            this.LConexion.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConexion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LConexion.Location = new System.Drawing.Point(524, 7);
            this.LConexion.Name = "LConexion";
            this.LConexion.Size = new System.Drawing.Size(64, 14);
            this.LConexion.TabIndex = 35;
            this.LConexion.Text = "Conectar";
            // 
            // BtnConexion
            // 
            this.BtnConexion.BackColor = System.Drawing.Color.Transparent;
            this.BtnConexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConexion.BackgroundImage")));
            this.BtnConexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConexion.Location = new System.Drawing.Point(525, 24);
            this.BtnConexion.Name = "BtnConexion";
            this.BtnConexion.Size = new System.Drawing.Size(61, 53);
            this.BtnConexion.TabIndex = 34;
            this.BtnConexion.UseVisualStyleBackColor = false;
            this.BtnConexion.Click += new System.EventHandler(this.BtnConexion_Click);
            // 
            // PuertoList
            // 
            this.PuertoList.FormattingEnabled = true;
            this.PuertoList.Location = new System.Drawing.Point(519, 83);
            this.PuertoList.Name = "PuertoList";
            this.PuertoList.Size = new System.Drawing.Size(73, 21);
            this.PuertoList.TabIndex = 33;
            // 
            // PuertoSerial
            // 
            this.PuertoSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerial_DataReceived);
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(487, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 14);
            this.label2.TabIndex = 39;
            this.label2.Text = "Ejecutar Calendario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(491, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 14);
            this.label1.TabIndex = 38;
            this.label1.Text = "Detener Calendario";
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEjecutar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEjecutar.BackgroundImage")));
            this.BtnEjecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEjecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEjecutar.Location = new System.Drawing.Point(527, 279);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(60, 48);
            this.BtnEjecutar.TabIndex = 37;
            this.BtnEjecutar.TabStop = false;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // BtnDetener
            // 
            this.BtnDetener.BackColor = System.Drawing.Color.Transparent;
            this.BtnDetener.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDetener.BackgroundImage")));
            this.BtnDetener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDetener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDetener.Location = new System.Drawing.Point(528, 199);
            this.BtnDetener.Name = "BtnDetener";
            this.BtnDetener.Size = new System.Drawing.Size(60, 48);
            this.BtnDetener.TabIndex = 36;
            this.BtnDetener.TabStop = false;
            this.BtnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // LecturaADC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEjecutar);
            this.Controls.Add(this.BtnDetener);
            this.Controls.Add(this.LConexion);
            this.Controls.Add(this.BtnConexion);
            this.Controls.Add(this.PuertoList);
            this.Controls.Add(this.BtnVerGraficas);
            this.Controls.Add(this.PBx_Monitor);
            this.Name = "LecturaADC";
            this.Text = "LecturaADC";
            ((System.ComponentModel.ISupportInitialize)(this.PBx_Monitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerGraficas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEjecutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDetener)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBx_Monitor;
        private System.Windows.Forms.PictureBox BtnVerGraficas;
        private System.Windows.Forms.Label LConexion;
        private System.Windows.Forms.Button BtnConexion;
        private System.Windows.Forms.ComboBox PuertoList;
        private System.IO.Ports.SerialPort PuertoSerial;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnEjecutar;
        private System.Windows.Forms.PictureBox BtnDetener;
    }
}