namespace InterfazGrafica
{
    partial class Version
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Version));
            this.BtnVersion = new System.Windows.Forms.PictureBox();
            this.BtnConexion = new System.Windows.Forms.Button();
            this.PuertoList = new System.Windows.Forms.ComboBox();
            this.PuertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.TextoVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVersion)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVersion
            // 
            this.BtnVersion.BackColor = System.Drawing.Color.Transparent;
            this.BtnVersion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVersion.BackgroundImage")));
            this.BtnVersion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVersion.Location = new System.Drawing.Point(276, 87);
            this.BtnVersion.Name = "BtnVersion";
            this.BtnVersion.Size = new System.Drawing.Size(63, 59);
            this.BtnVersion.TabIndex = 0;
            this.BtnVersion.TabStop = false;
            this.BtnVersion.Click += new System.EventHandler(this.BtnVersion_Click);
            // 
            // BtnConexion
            // 
            this.BtnConexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConexion.BackgroundImage")));
            this.BtnConexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConexion.Location = new System.Drawing.Point(406, 12);
            this.BtnConexion.Name = "BtnConexion";
            this.BtnConexion.Size = new System.Drawing.Size(61, 53);
            this.BtnConexion.TabIndex = 7;
            this.BtnConexion.UseVisualStyleBackColor = true;
            this.BtnConexion.Click += new System.EventHandler(this.BtnConexion_Click);
            // 
            // PuertoList
            // 
            this.PuertoList.FormattingEnabled = true;
            this.PuertoList.Location = new System.Drawing.Point(400, 71);
            this.PuertoList.Name = "PuertoList";
            this.PuertoList.Size = new System.Drawing.Size(73, 21);
            this.PuertoList.TabIndex = 6;
            // 
            // PuertoSerial
            // 
            this.PuertoSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerial_DataReceived);
            // 
            // TextoVersion
            // 
            this.TextoVersion.AutoSize = true;
            this.TextoVersion.BackColor = System.Drawing.Color.Transparent;
            this.TextoVersion.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoVersion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextoVersion.Location = new System.Drawing.Point(12, 33);
            this.TextoVersion.Name = "TextoVersion";
            this.TextoVersion.Size = new System.Drawing.Size(127, 32);
            this.TextoVersion.TabIndex = 8;
            this.TextoVersion.Text = "Actualizar";
            // 
            // Version
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(479, 232);
            this.Controls.Add(this.TextoVersion);
            this.Controls.Add(this.BtnConexion);
            this.Controls.Add(this.PuertoList);
            this.Controls.Add(this.BtnVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Version";
            this.Text = "Version";
            ((System.ComponentModel.ISupportInitialize)(this.BtnVersion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnVersion;
        private System.Windows.Forms.Button BtnConexion;
        private System.Windows.Forms.ComboBox PuertoList;
        private System.IO.Ports.SerialPort PuertoSerial;
        private System.Windows.Forms.Label TextoVersion;
    }
}