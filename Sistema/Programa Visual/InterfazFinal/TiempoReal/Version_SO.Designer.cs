namespace TiempoReal
{
    partial class Version_SO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Version_SO));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.PuertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.TxBx_Version = new System.Windows.Forms.TextBox();
            this.BtnConexion = new System.Windows.Forms.Button();
            this.PuertoList = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 258);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(480, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "hh:mm:ss";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ver version del  S.O.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PuertoSerial
            // 
            this.PuertoSerial.PortName = "COM6";
            this.PuertoSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // TxBx_Version
            // 
            this.TxBx_Version.Location = new System.Drawing.Point(37, 210);
            this.TxBx_Version.Name = "TxBx_Version";
            this.TxBx_Version.Size = new System.Drawing.Size(130, 24);
            this.TxBx_Version.TabIndex = 4;
            // 
            // BtnConexion
            // 
            this.BtnConexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConexion.BackgroundImage")));
            this.BtnConexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConexion.Location = new System.Drawing.Point(67, 12);
            this.BtnConexion.Name = "BtnConexion";
            this.BtnConexion.Size = new System.Drawing.Size(68, 61);
            this.BtnConexion.TabIndex = 7;
            this.BtnConexion.UseVisualStyleBackColor = true;
            this.BtnConexion.Click += new System.EventHandler(this.BtnConexion_Click);
            // 
            // PuertoList
            // 
            this.PuertoList.FormattingEnabled = true;
            this.PuertoList.Location = new System.Drawing.Point(54, 79);
            this.PuertoList.Name = "PuertoList";
            this.PuertoList.Size = new System.Drawing.Size(94, 24);
            this.PuertoList.TabIndex = 6;
            // 
            // Version_SO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 280);
            this.Controls.Add(this.BtnConexion);
            this.Controls.Add(this.PuertoList);
            this.Controls.Add(this.TxBx_Version);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Version_SO";
            this.Text = "Version_S.O.";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort PuertoSerial;
        private System.Windows.Forms.TextBox TxBx_Version;
        private System.Windows.Forms.Button BtnConexion;
        private System.Windows.Forms.ComboBox PuertoList;
    }
}