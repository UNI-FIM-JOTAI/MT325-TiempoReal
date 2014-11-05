namespace dsp
{
    partial class Form1
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
            this.conectar = new System.Windows.Forms.PictureBox();
            this.mostrar = new System.Windows.Forms.PictureBox();
            this.iniciar = new System.Windows.Forms.PictureBox();
            this.cw = new System.Windows.Forms.PictureBox();
            this.led2 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Recibido = new System.Windows.Forms.TextBox();
            this.Enviado = new System.Windows.Forms.TextBox();
            this.lista_Enviado = new System.Windows.Forms.TextBox();
            this.Puertos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.led3 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.conectar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.led3)).BeginInit();
            this.SuspendLayout();
            // 
            // conectar
            // 
            this.conectar.BackColor = System.Drawing.Color.Transparent;
            this.conectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conectar.Image = global::dsp.Properties.Resources.conect;
            this.conectar.Location = new System.Drawing.Point(59, 49);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(85, 82);
            this.conectar.TabIndex = 0;
            this.conectar.TabStop = false;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // mostrar
            // 
            this.mostrar.BackColor = System.Drawing.Color.Transparent;
            this.mostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mostrar.Image = global::dsp.Properties.Resources.ampere;
            this.mostrar.Location = new System.Drawing.Point(356, 29);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(113, 52);
            this.mostrar.TabIndex = 1;
            this.mostrar.TabStop = false;
            this.mostrar.Click += new System.EventHandler(this.corriente_Click);
            // 
            // iniciar
            // 
            this.iniciar.BackColor = System.Drawing.Color.Transparent;
            this.iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iniciar.Image = global::dsp.Properties.Resources.rpm;
            this.iniciar.Location = new System.Drawing.Point(66, 36);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(113, 52);
            this.iniciar.TabIndex = 2;
            this.iniciar.TabStop = false;
            this.iniciar.Click += new System.EventHandler(this.velocidad_Click);
            // 
            // cw
            // 
            this.cw.BackColor = System.Drawing.Color.Transparent;
            this.cw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cw.ErrorImage = null;
            this.cw.Image = global::dsp.Properties.Resources.cw2;
            this.cw.Location = new System.Drawing.Point(16, 33);
            this.cw.Name = "cw";
            this.cw.Size = new System.Drawing.Size(72, 69);
            this.cw.TabIndex = 4;
            this.cw.TabStop = false;
            this.cw.Click += new System.EventHandler(this.cw_Click);
            // 
            // led2
            // 
            this.led2.BackColor = System.Drawing.Color.Transparent;
            this.led2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.led2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.led2.ErrorImage = global::dsp.Properties.Resources.ccw;
            this.led2.Image = global::dsp.Properties.Resources.ccw1;
            this.led2.Location = new System.Drawing.Point(321, 33);
            this.led2.Name = "led2";
            this.led2.Size = new System.Drawing.Size(72, 69);
            this.led2.TabIndex = 5;
            this.led2.TabStop = false;
            this.led2.Click += new System.EventHandler(this.ccw_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115000;
            this.serialPort1.PortName = "COM6";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(94, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Programa 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(399, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Programa 2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cw);
            this.groupBox1.Controls.Add(this.led2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(268, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 120);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procesos Infinitos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(150, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Conectar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(352, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Programa 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(62, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Programa 3";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.iniciar);
            this.groupBox2.Controls.Add(this.mostrar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(268, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 150);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procesos Finitos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(69, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Recibido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(464, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Enviado";
            // 
            // Recibido
            // 
            this.Recibido.Location = new System.Drawing.Point(171, 356);
            this.Recibido.Name = "Recibido";
            this.Recibido.Size = new System.Drawing.Size(138, 20);
            this.Recibido.TabIndex = 17;
            // 
            // Enviado
            // 
            this.Enviado.Location = new System.Drawing.Point(565, 356);
            this.Enviado.Name = "Enviado";
            this.Enviado.Size = new System.Drawing.Size(132, 20);
            this.Enviado.TabIndex = 18;
            // 
            // lista_Enviado
            // 
            this.lista_Enviado.Cursor = System.Windows.Forms.Cursors.Default;
            this.lista_Enviado.Location = new System.Drawing.Point(467, 403);
            this.lista_Enviado.Multiline = true;
            this.lista_Enviado.Name = "lista_Enviado";
            this.lista_Enviado.ReadOnly = true;
            this.lista_Enviado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lista_Enviado.Size = new System.Drawing.Size(350, 103);
            this.lista_Enviado.TabIndex = 3;
            // 
            // Puertos
            // 
            this.Puertos.FormattingEnabled = true;
            this.Puertos.Location = new System.Drawing.Point(48, 155);
            this.Puertos.Name = "Puertos";
            this.Puertos.Size = new System.Drawing.Size(121, 21);
            this.Puertos.TabIndex = 19;
            this.Puertos.SelectedIndexChanged += new System.EventHandler(this.Puertos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(55, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ver Procesos";
            // 
            // led3
            // 
            this.led3.BackColor = System.Drawing.Color.Transparent;
            this.led3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.led3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.led3.Image = global::dsp.Properties.Resources.stop;
            this.led3.Location = new System.Drawing.Point(87, 213);
            this.led3.Name = "led3";
            this.led3.Size = new System.Drawing.Size(82, 69);
            this.led3.TabIndex = 6;
            this.led3.TabStop = false;
            this.led3.Click += new System.EventHandler(this.stop_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(63, 403);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 95);
            this.listBox1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::dsp.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(846, 518);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.led3);
            this.Controls.Add(this.Puertos);
            this.Controls.Add(this.lista_Enviado);
            this.Controls.Add(this.Enviado);
            this.Controls.Add(this.Recibido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.conectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.conectar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.led3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox conectar;
        private System.Windows.Forms.PictureBox mostrar;
        private System.Windows.Forms.PictureBox iniciar;
        private System.Windows.Forms.PictureBox cw;
        private System.Windows.Forms.PictureBox led2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Recibido;
        private System.Windows.Forms.TextBox Enviado;
        private System.Windows.Forms.TextBox lista_Enviado;
        private System.Windows.Forms.ComboBox Puertos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox led3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

