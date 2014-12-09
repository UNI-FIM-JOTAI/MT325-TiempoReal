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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturaADC));
            this.PBx_Monitor = new System.Windows.Forms.PictureBox();
            this.BtnVerGraficas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBx_Monitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerGraficas)).BeginInit();
            this.SuspendLayout();
            // 
            // PBx_Monitor
            // 
            this.PBx_Monitor.Location = new System.Drawing.Point(31, 25);
            this.PBx_Monitor.Name = "PBx_Monitor";
            this.PBx_Monitor.Size = new System.Drawing.Size(467, 328);
            this.PBx_Monitor.TabIndex = 0;
            this.PBx_Monitor.TabStop = false;
            // 
            // BtnVerGraficas
            // 
            this.BtnVerGraficas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVerGraficas.BackgroundImage")));
            this.BtnVerGraficas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVerGraficas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerGraficas.Location = new System.Drawing.Point(539, 25);
            this.BtnVerGraficas.Name = "BtnVerGraficas";
            this.BtnVerGraficas.Size = new System.Drawing.Size(58, 60);
            this.BtnVerGraficas.TabIndex = 1;
            this.BtnVerGraficas.TabStop = false;
            this.BtnVerGraficas.Click += new System.EventHandler(this.BtnVerGraficas_Click);
            // 
            // LecturaADC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 378);
            this.Controls.Add(this.BtnVerGraficas);
            this.Controls.Add(this.PBx_Monitor);
            this.Name = "LecturaADC";
            this.Text = "LecturaADC";
            ((System.ComponentModel.ISupportInitialize)(this.PBx_Monitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerGraficas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBx_Monitor;
        private System.Windows.Forms.PictureBox BtnVerGraficas;
    }
}