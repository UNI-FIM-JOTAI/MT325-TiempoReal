namespace TiempoReal
{
    partial class Calendario_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario_main));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.procesoN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.rtfTerminal = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textD1 = new System.Windows.Forms.TextBox();
            this.textM1 = new System.Windows.Forms.TextBox();
            this.textM2 = new System.Windows.Forms.TextBox();
            this.textD2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textM3 = new System.Windows.Forms.TextBox();
            this.textD3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textM4 = new System.Windows.Forms.TextBox();
            this.textD4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textM5 = new System.Windows.Forms.TextBox();
            this.textD5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(9, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Calendarizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(9, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "C&argar Calendario";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(192, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Ejecutar Calendario";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // procesoN
            // 
            this.procesoN.Location = new System.Drawing.Point(97, 27);
            this.procesoN.Name = "procesoN";
            this.procesoN.Size = new System.Drawing.Size(113, 24);
            this.procesoN.TabIndex = 3;
            this.procesoN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.procesoN.TextChanged += new System.EventHandler(this.procesoN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "PROCESO";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(9, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 36);
            this.button4.TabIndex = 5;
            this.button4.Text = "Elegir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.Location = new System.Drawing.Point(110, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 36);
            this.button5.TabIndex = 6;
            this.button5.Text = "Quitar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // rtfTerminal
            // 
            this.rtfTerminal.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtfTerminal.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfTerminal.Location = new System.Drawing.Point(591, 0);
            this.rtfTerminal.Name = "rtfTerminal";
            this.rtfTerminal.Size = new System.Drawing.Size(411, 528);
            this.rtfTerminal.TabIndex = 7;
            this.rtfTerminal.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Proceso 1:";
            // 
            // textD1
            // 
            this.textD1.Enabled = false;
            this.textD1.Location = new System.Drawing.Point(352, 103);
            this.textD1.Name = "textD1";
            this.textD1.Size = new System.Drawing.Size(87, 24);
            this.textD1.TabIndex = 9;
            // 
            // textM1
            // 
            this.textM1.Enabled = false;
            this.textM1.Location = new System.Drawing.Point(454, 103);
            this.textM1.Name = "textM1";
            this.textM1.Size = new System.Drawing.Size(88, 24);
            this.textM1.TabIndex = 10;
            // 
            // textM2
            // 
            this.textM2.Enabled = false;
            this.textM2.Location = new System.Drawing.Point(454, 145);
            this.textM2.Name = "textM2";
            this.textM2.Size = new System.Drawing.Size(88, 24);
            this.textM2.TabIndex = 13;
            // 
            // textD2
            // 
            this.textD2.Enabled = false;
            this.textD2.Location = new System.Drawing.Point(352, 145);
            this.textD2.Name = "textD2";
            this.textD2.Size = new System.Drawing.Size(87, 24);
            this.textD2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Proceso 2:";
            // 
            // textM3
            // 
            this.textM3.Enabled = false;
            this.textM3.Location = new System.Drawing.Point(454, 185);
            this.textM3.Name = "textM3";
            this.textM3.Size = new System.Drawing.Size(88, 24);
            this.textM3.TabIndex = 16;
            // 
            // textD3
            // 
            this.textD3.Enabled = false;
            this.textD3.Location = new System.Drawing.Point(352, 185);
            this.textD3.Name = "textD3";
            this.textD3.Size = new System.Drawing.Size(87, 24);
            this.textD3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Proceso 3:";
            // 
            // textM4
            // 
            this.textM4.Enabled = false;
            this.textM4.Location = new System.Drawing.Point(454, 226);
            this.textM4.Name = "textM4";
            this.textM4.Size = new System.Drawing.Size(88, 24);
            this.textM4.TabIndex = 19;
            // 
            // textD4
            // 
            this.textD4.Enabled = false;
            this.textD4.Location = new System.Drawing.Point(352, 226);
            this.textD4.Name = "textD4";
            this.textD4.Size = new System.Drawing.Size(87, 24);
            this.textD4.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Proceso 4:";
            // 
            // textM5
            // 
            this.textM5.Enabled = false;
            this.textM5.Location = new System.Drawing.Point(454, 269);
            this.textM5.Name = "textM5";
            this.textM5.Size = new System.Drawing.Size(88, 24);
            this.textM5.TabIndex = 22;
            // 
            // textD5
            // 
            this.textD5.Enabled = false;
            this.textD5.Location = new System.Drawing.Point(352, 269);
            this.textD5.Name = "textD5";
            this.textD5.Size = new System.Drawing.Size(87, 24);
            this.textD5.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Proceso 5:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textM5);
            this.groupBox1.Controls.Add(this.procesoN);
            this.groupBox1.Controls.Add(this.textD5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.textM4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textD4);
            this.groupBox1.Controls.Add(this.textD1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textM1);
            this.groupBox1.Controls.Add(this.textM3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textD3);
            this.groupBox1.Controls.Add(this.textD2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textM2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 311);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel de control Calendarizacion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 203);
            this.textBox1.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Duracion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 34);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tiempo de\r\n muestreo";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(428, 127);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 39);
            this.button6.TabIndex = 24;
            this.button6.Text = "SALIR";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(12, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 183);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Botones";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button11.Location = new System.Drawing.Point(389, 25);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(171, 33);
            this.button11.TabIndex = 29;
            this.button11.Text = "Liberar PCB\'s";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button10.Location = new System.Drawing.Point(192, 129);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(177, 27);
            this.button10.TabIndex = 28;
            this.button10.Text = "Detener Calendario";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button9.Location = new System.Drawing.Point(9, 81);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(177, 31);
            this.button9.TabIndex = 27;
            this.button9.Text = "Cargar Direcciones";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button8.Location = new System.Drawing.Point(192, 25);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(177, 33);
            this.button8.TabIndex = 26;
            this.button8.Text = "Ver Vector ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Lime;
            this.button7.Location = new System.Drawing.Point(435, 79);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 39);
            this.button7.TabIndex = 25;
            this.button7.Text = "AYUDA";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM23";
            // 
            // Calendario_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1002, 528);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtfTerminal);
            this.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calendario_main";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Calendario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox procesoN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox rtfTerminal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textD1;
        private System.Windows.Forms.TextBox textM1;
        private System.Windows.Forms.TextBox textM2;
        private System.Windows.Forms.TextBox textD2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textM3;
        private System.Windows.Forms.TextBox textD3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textM4;
        private System.Windows.Forms.TextBox textD4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textM5;
        private System.Windows.Forms.TextBox textD5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}