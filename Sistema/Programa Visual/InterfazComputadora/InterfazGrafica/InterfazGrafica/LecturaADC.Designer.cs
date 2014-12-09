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
            ((System.ComponentModel.ISupportInitialize)(this.PBx_Monitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerGraficas)).BeginInit();
            this.SuspendLayout();
            // 
            // PBx_Monitor
            // 
            this.PBx_Monitor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PBx_Monitor.Location = new System.Drawing.Point(12, 24);
            this.PBx_Monitor.Name = "PBx_Monitor";
            this.PBx_Monitor.Size = new System.Drawing.Size(450, 325);
            this.PBx_Monitor.TabIndex = 0;
            this.PBx_Monitor.TabStop = false;
            // 
            // BtnVerGraficas
            // 
            this.BtnVerGraficas.BackColor = System.Drawing.Color.Transparent;
            this.BtnVerGraficas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVerGraficas.BackgroundImage")));
            this.BtnVerGraficas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVerGraficas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerGraficas.Location = new System.Drawing.Point(528, 141);
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
            this.LConexion.Location = new System.Drawing.Point(524, 24);
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
            this.BtnConexion.Location = new System.Drawing.Point(525, 41);
            this.BtnConexion.Name = "BtnConexion";
            this.BtnConexion.Size = new System.Drawing.Size(61, 53);
            this.BtnConexion.TabIndex = 34;
            this.BtnConexion.UseVisualStyleBackColor = false;
            this.BtnConexion.Click += new System.EventHandler(this.BtnConexion_Click);
            // 
            // PuertoList
            // 
            this.PuertoList.FormattingEnabled = true;
            this.PuertoList.Location = new System.Drawing.Point(519, 100);
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
            // LecturaADC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 378);
            this.Controls.Add(this.LConexion);
            this.Controls.Add(this.BtnConexion);
            this.Controls.Add(this.PuertoList);
            this.Controls.Add(this.BtnVerGraficas);
            this.Controls.Add(this.PBx_Monitor);
            this.Name = "LecturaADC";
            this.Text = "LecturaADC";
            ((System.ComponentModel.ISupportInitialize)(this.PBx_Monitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerGraficas)).EndInit();
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
    }
}