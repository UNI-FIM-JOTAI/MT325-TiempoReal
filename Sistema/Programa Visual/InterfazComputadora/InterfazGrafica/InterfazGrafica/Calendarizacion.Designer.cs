namespace InterfazGrafica
{
    partial class Caledarizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caledarizacion));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnConexion = new System.Windows.Forms.Button();
            this.PuertoList = new System.Windows.Forms.ComboBox();
            this.PuertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.TxBx_D1 = new System.Windows.Forms.TextBox();
            this.TxBx_T1 = new System.Windows.Forms.TextBox();
            this.TxBx_T2 = new System.Windows.Forms.TextBox();
            this.TxBx_D2 = new System.Windows.Forms.TextBox();
            this.TxBx_T3 = new System.Windows.Forms.TextBox();
            this.TxBx_D3 = new System.Windows.Forms.TextBox();
            this.TxBx_T4 = new System.Windows.Forms.TextBox();
            this.TxBx_D4 = new System.Windows.Forms.TextBox();
            this.TxBx_T5 = new System.Windows.Forms.TextBox();
            this.TxBx_D5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ChBx_1 = new System.Windows.Forms.CheckBox();
            this.ChBx_2 = new System.Windows.Forms.CheckBox();
            this.ChBx_3 = new System.Windows.Forms.CheckBox();
            this.ChBx_4 = new System.Windows.Forms.CheckBox();
            this.ChBx_5 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(445, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(274, 389);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BtnConexion
            // 
            this.BtnConexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConexion.BackgroundImage")));
            this.BtnConexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConexion.Location = new System.Drawing.Point(24, 12);
            this.BtnConexion.Name = "BtnConexion";
            this.BtnConexion.Size = new System.Drawing.Size(68, 61);
            this.BtnConexion.TabIndex = 3;
            this.BtnConexion.UseVisualStyleBackColor = true;
            this.BtnConexion.Click += new System.EventHandler(this.BtnConexion_Click);
            // 
            // PuertoList
            // 
            this.PuertoList.FormattingEnabled = true;
            this.PuertoList.Location = new System.Drawing.Point(11, 79);
            this.PuertoList.Name = "PuertoList";
            this.PuertoList.Size = new System.Drawing.Size(94, 21);
            this.PuertoList.TabIndex = 2;
            this.PuertoList.SelectedIndexChanged += new System.EventHandler(this.PuertoList_SelectedIndexChanged);
            // 
            // TxBx_D1
            // 
            this.TxBx_D1.Location = new System.Drawing.Point(125, 44);
            this.TxBx_D1.Name = "TxBx_D1";
            this.TxBx_D1.Size = new System.Drawing.Size(86, 24);
            this.TxBx_D1.TabIndex = 4;
            // 
            // TxBx_T1
            // 
            this.TxBx_T1.Location = new System.Drawing.Point(247, 44);
            this.TxBx_T1.Name = "TxBx_T1";
            this.TxBx_T1.Size = new System.Drawing.Size(86, 24);
            this.TxBx_T1.TabIndex = 5;
            // 
            // TxBx_T2
            // 
            this.TxBx_T2.Location = new System.Drawing.Point(247, 70);
            this.TxBx_T2.Name = "TxBx_T2";
            this.TxBx_T2.Size = new System.Drawing.Size(86, 24);
            this.TxBx_T2.TabIndex = 8;
            // 
            // TxBx_D2
            // 
            this.TxBx_D2.Location = new System.Drawing.Point(125, 70);
            this.TxBx_D2.Name = "TxBx_D2";
            this.TxBx_D2.Size = new System.Drawing.Size(86, 24);
            this.TxBx_D2.TabIndex = 7;
            // 
            // TxBx_T3
            // 
            this.TxBx_T3.Location = new System.Drawing.Point(247, 96);
            this.TxBx_T3.Name = "TxBx_T3";
            this.TxBx_T3.Size = new System.Drawing.Size(86, 24);
            this.TxBx_T3.TabIndex = 11;
            // 
            // TxBx_D3
            // 
            this.TxBx_D3.Location = new System.Drawing.Point(125, 96);
            this.TxBx_D3.Name = "TxBx_D3";
            this.TxBx_D3.Size = new System.Drawing.Size(86, 24);
            this.TxBx_D3.TabIndex = 10;
            // 
            // TxBx_T4
            // 
            this.TxBx_T4.Location = new System.Drawing.Point(247, 122);
            this.TxBx_T4.Name = "TxBx_T4";
            this.TxBx_T4.Size = new System.Drawing.Size(86, 24);
            this.TxBx_T4.TabIndex = 14;
            // 
            // TxBx_D4
            // 
            this.TxBx_D4.Location = new System.Drawing.Point(125, 122);
            this.TxBx_D4.Name = "TxBx_D4";
            this.TxBx_D4.Size = new System.Drawing.Size(86, 24);
            this.TxBx_D4.TabIndex = 13;
            // 
            // TxBx_T5
            // 
            this.TxBx_T5.Location = new System.Drawing.Point(247, 148);
            this.TxBx_T5.Name = "TxBx_T5";
            this.TxBx_T5.Size = new System.Drawing.Size(86, 24);
            this.TxBx_T5.TabIndex = 17;
            // 
            // TxBx_D5
            // 
            this.TxBx_D5.Location = new System.Drawing.Point(125, 148);
            this.TxBx_D5.Name = "TxBx_D5";
            this.TxBx_D5.Size = new System.Drawing.Size(86, 24);
            this.TxBx_D5.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ChBx_5);
            this.groupBox1.Controls.Add(this.ChBx_4);
            this.groupBox1.Controls.Add(this.ChBx_3);
            this.groupBox1.Controls.Add(this.ChBx_2);
            this.groupBox1.Controls.Add(this.ChBx_1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxBx_T5);
            this.groupBox1.Controls.Add(this.TxBx_D5);
            this.groupBox1.Controls.Add(this.TxBx_T4);
            this.groupBox1.Controls.Add(this.TxBx_D4);
            this.groupBox1.Controls.Add(this.TxBx_T3);
            this.groupBox1.Controls.Add(this.TxBx_D3);
            this.groupBox1.Controls.Add(this.TxBx_T2);
            this.groupBox1.Controls.Add(this.TxBx_D2);
            this.groupBox1.Controls.Add(this.TxBx_T1);
            this.groupBox1.Controls.Add(this.TxBx_D1);
            this.groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(19, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 182);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROCESOS DEL PIC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "DURACION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "TIEMPO DE MUESTREO";
            // 
            // ChBx_1
            // 
            this.ChBx_1.AutoSize = true;
            this.ChBx_1.Location = new System.Drawing.Point(20, 46);
            this.ChBx_1.Name = "ChBx_1";
            this.ChBx_1.Size = new System.Drawing.Size(104, 21);
            this.ChBx_1.TabIndex = 21;
            this.ChBx_1.Text = "PROCESO 1";
            this.ChBx_1.UseVisualStyleBackColor = true;
            // 
            // ChBx_2
            // 
            this.ChBx_2.AutoSize = true;
            this.ChBx_2.Location = new System.Drawing.Point(20, 72);
            this.ChBx_2.Name = "ChBx_2";
            this.ChBx_2.Size = new System.Drawing.Size(105, 21);
            this.ChBx_2.TabIndex = 22;
            this.ChBx_2.Text = "PROCESO 2";
            this.ChBx_2.UseVisualStyleBackColor = true;
            // 
            // ChBx_3
            // 
            this.ChBx_3.AutoSize = true;
            this.ChBx_3.Location = new System.Drawing.Point(20, 98);
            this.ChBx_3.Name = "ChBx_3";
            this.ChBx_3.Size = new System.Drawing.Size(105, 21);
            this.ChBx_3.TabIndex = 23;
            this.ChBx_3.Text = "PROCESO 3";
            this.ChBx_3.UseVisualStyleBackColor = true;
            // 
            // ChBx_4
            // 
            this.ChBx_4.AutoSize = true;
            this.ChBx_4.Location = new System.Drawing.Point(20, 124);
            this.ChBx_4.Name = "ChBx_4";
            this.ChBx_4.Size = new System.Drawing.Size(106, 21);
            this.ChBx_4.TabIndex = 24;
            this.ChBx_4.Text = "PROCESO 4";
            this.ChBx_4.UseVisualStyleBackColor = true;
            // 
            // ChBx_5
            // 
            this.ChBx_5.AutoSize = true;
            this.ChBx_5.Location = new System.Drawing.Point(20, 150);
            this.ChBx_5.Name = "ChBx_5";
            this.ChBx_5.Size = new System.Drawing.Size(106, 21);
            this.ChBx_5.TabIndex = 25;
            this.ChBx_5.Text = "PROCESO 5";
            this.ChBx_5.UseVisualStyleBackColor = true;
            // 
            // Caledarizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnConexion);
            this.Controls.Add(this.PuertoList);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Caledarizacion";
            this.Text = "Calendarizacion";
            this.Load += new System.EventHandler(this.Caledarizacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnConexion;
        private System.Windows.Forms.ComboBox PuertoList;
        private System.IO.Ports.SerialPort PuertoSerial;
        private System.Windows.Forms.TextBox TxBx_D1;
        private System.Windows.Forms.TextBox TxBx_T1;
        private System.Windows.Forms.TextBox TxBx_T2;
        private System.Windows.Forms.TextBox TxBx_D2;
        private System.Windows.Forms.TextBox TxBx_T3;
        private System.Windows.Forms.TextBox TxBx_D3;
        private System.Windows.Forms.TextBox TxBx_T4;
        private System.Windows.Forms.TextBox TxBx_D4;
        private System.Windows.Forms.TextBox TxBx_T5;
        private System.Windows.Forms.TextBox TxBx_D5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ChBx_5;
        private System.Windows.Forms.CheckBox ChBx_4;
        private System.Windows.Forms.CheckBox ChBx_3;
        private System.Windows.Forms.CheckBox ChBx_2;
        private System.Windows.Forms.CheckBox ChBx_1;
    }
}