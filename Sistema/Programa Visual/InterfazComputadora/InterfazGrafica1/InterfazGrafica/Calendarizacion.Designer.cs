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
            this.RTBx_Terminal = new System.Windows.Forms.RichTextBox();
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
            this.ChBx_PeriodoMuestreo = new System.Windows.Forms.CheckBox();
            this.ChBx_Duracion = new System.Windows.Forms.CheckBox();
            this.ChBx_5 = new System.Windows.Forms.CheckBox();
            this.ChBx_4 = new System.Windows.Forms.CheckBox();
            this.ChBx_3 = new System.Windows.Forms.CheckBox();
            this.ChBx_2 = new System.Windows.Forms.CheckBox();
            this.ChBx_1 = new System.Windows.Forms.CheckBox();
            this.BtnCalendarizar = new System.Windows.Forms.Button();
            this.Calendarizar = new System.Windows.Forms.Label();
            this.BtnPredeterminado = new System.Windows.Forms.PictureBox();
            this.Predeterminado = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.PictureBox();
            this.LimiparPantalla = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.BtnCargar = new System.Windows.Forms.PictureBox();
            this.BtnDetener = new System.Windows.Forms.PictureBox();
            this.BtnEjecutar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPredeterminado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDetener)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEjecutar)).BeginInit();
            this.SuspendLayout();
            // 
            // RTBx_Terminal
            // 
            this.RTBx_Terminal.Location = new System.Drawing.Point(483, 0);
            this.RTBx_Terminal.Name = "RTBx_Terminal";
            this.RTBx_Terminal.Size = new System.Drawing.Size(274, 415);
            this.RTBx_Terminal.TabIndex = 0;
            this.RTBx_Terminal.Text = "";
            // 
            // BtnConexion
            // 
            this.BtnConexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConexion.BackgroundImage")));
            this.BtnConexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConexion.Location = new System.Drawing.Point(44, 20);
            this.BtnConexion.Name = "BtnConexion";
            this.BtnConexion.Size = new System.Drawing.Size(61, 53);
            this.BtnConexion.TabIndex = 3;
            this.BtnConexion.UseVisualStyleBackColor = true;
            this.BtnConexion.Click += new System.EventHandler(this.BtnConexion_Click);
            // 
            // PuertoList
            // 
            this.PuertoList.FormattingEnabled = true;
            this.PuertoList.Location = new System.Drawing.Point(38, 79);
            this.PuertoList.Name = "PuertoList";
            this.PuertoList.Size = new System.Drawing.Size(73, 21);
            this.PuertoList.TabIndex = 2;
            this.PuertoList.SelectedIndexChanged += new System.EventHandler(this.PuertoList_SelectedIndexChanged);
            // 
            // PuertoSerial
            // 
            this.PuertoSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerial_DataReceived);
            // 
            // TxBx_D1
            // 
            this.TxBx_D1.Location = new System.Drawing.Point(132, 44);
            this.TxBx_D1.Name = "TxBx_D1";
            this.TxBx_D1.Size = new System.Drawing.Size(104, 24);
            this.TxBx_D1.TabIndex = 4;
            // 
            // TxBx_T1
            // 
            this.TxBx_T1.Location = new System.Drawing.Point(250, 43);
            this.TxBx_T1.Name = "TxBx_T1";
            this.TxBx_T1.Size = new System.Drawing.Size(171, 24);
            this.TxBx_T1.TabIndex = 5;
            // 
            // TxBx_T2
            // 
            this.TxBx_T2.Location = new System.Drawing.Point(250, 69);
            this.TxBx_T2.Name = "TxBx_T2";
            this.TxBx_T2.Size = new System.Drawing.Size(171, 24);
            this.TxBx_T2.TabIndex = 8;
            // 
            // TxBx_D2
            // 
            this.TxBx_D2.Location = new System.Drawing.Point(132, 70);
            this.TxBx_D2.Name = "TxBx_D2";
            this.TxBx_D2.Size = new System.Drawing.Size(104, 24);
            this.TxBx_D2.TabIndex = 7;
            // 
            // TxBx_T3
            // 
            this.TxBx_T3.Location = new System.Drawing.Point(250, 95);
            this.TxBx_T3.Name = "TxBx_T3";
            this.TxBx_T3.Size = new System.Drawing.Size(171, 24);
            this.TxBx_T3.TabIndex = 11;
            // 
            // TxBx_D3
            // 
            this.TxBx_D3.Location = new System.Drawing.Point(132, 96);
            this.TxBx_D3.Name = "TxBx_D3";
            this.TxBx_D3.Size = new System.Drawing.Size(104, 24);
            this.TxBx_D3.TabIndex = 10;
            // 
            // TxBx_T4
            // 
            this.TxBx_T4.Location = new System.Drawing.Point(250, 121);
            this.TxBx_T4.Name = "TxBx_T4";
            this.TxBx_T4.Size = new System.Drawing.Size(171, 24);
            this.TxBx_T4.TabIndex = 14;
            // 
            // TxBx_D4
            // 
            this.TxBx_D4.Location = new System.Drawing.Point(132, 122);
            this.TxBx_D4.Name = "TxBx_D4";
            this.TxBx_D4.Size = new System.Drawing.Size(104, 24);
            this.TxBx_D4.TabIndex = 13;
            // 
            // TxBx_T5
            // 
            this.TxBx_T5.Location = new System.Drawing.Point(250, 147);
            this.TxBx_T5.Name = "TxBx_T5";
            this.TxBx_T5.Size = new System.Drawing.Size(171, 24);
            this.TxBx_T5.TabIndex = 17;
            // 
            // TxBx_D5
            // 
            this.TxBx_D5.Location = new System.Drawing.Point(132, 148);
            this.TxBx_D5.Name = "TxBx_D5";
            this.TxBx_D5.Size = new System.Drawing.Size(104, 24);
            this.TxBx_D5.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ChBx_PeriodoMuestreo);
            this.groupBox1.Controls.Add(this.ChBx_Duracion);
            this.groupBox1.Controls.Add(this.ChBx_5);
            this.groupBox1.Controls.Add(this.ChBx_4);
            this.groupBox1.Controls.Add(this.ChBx_3);
            this.groupBox1.Controls.Add(this.ChBx_2);
            this.groupBox1.Controls.Add(this.ChBx_1);
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
            this.groupBox1.Location = new System.Drawing.Point(24, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 186);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROCESOS DEL PIC";
            // 
            // ChBx_PeriodoMuestreo
            // 
            this.ChBx_PeriodoMuestreo.AutoSize = true;
            this.ChBx_PeriodoMuestreo.Location = new System.Drawing.Point(250, 20);
            this.ChBx_PeriodoMuestreo.Name = "ChBx_PeriodoMuestreo";
            this.ChBx_PeriodoMuestreo.Size = new System.Drawing.Size(176, 21);
            this.ChBx_PeriodoMuestreo.TabIndex = 27;
            this.ChBx_PeriodoMuestreo.Text = "PERIODO MUESTREO";
            this.ChBx_PeriodoMuestreo.UseVisualStyleBackColor = true;
            this.ChBx_PeriodoMuestreo.CheckedChanged += new System.EventHandler(this.ChBx_PeriodoMuestreo_CheckedChanged);
            // 
            // ChBx_Duracion
            // 
            this.ChBx_Duracion.AutoSize = true;
            this.ChBx_Duracion.Location = new System.Drawing.Point(132, 20);
            this.ChBx_Duracion.Name = "ChBx_Duracion";
            this.ChBx_Duracion.Size = new System.Drawing.Size(104, 21);
            this.ChBx_Duracion.TabIndex = 26;
            this.ChBx_Duracion.Text = "DURACION";
            this.ChBx_Duracion.UseVisualStyleBackColor = true;
            this.ChBx_Duracion.CheckedChanged += new System.EventHandler(this.ChBx_Duracion_CheckedChanged);
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
            // ChBx_1
            // 
            this.ChBx_1.AutoSize = true;
            this.ChBx_1.Location = new System.Drawing.Point(20, 46);
            this.ChBx_1.Name = "ChBx_1";
            this.ChBx_1.Size = new System.Drawing.Size(104, 21);
            this.ChBx_1.TabIndex = 21;
            this.ChBx_1.Text = "PROCESO 1";
            this.ChBx_1.UseVisualStyleBackColor = true;
            this.ChBx_1.CheckedChanged += new System.EventHandler(this.ChBx_1_CheckedChanged);
            // 
            // BtnCalendarizar
            // 
            this.BtnCalendarizar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCalendarizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCalendarizar.BackgroundImage")));
            this.BtnCalendarizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCalendarizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalendarizar.Location = new System.Drawing.Point(145, 20);
            this.BtnCalendarizar.Name = "BtnCalendarizar";
            this.BtnCalendarizar.Size = new System.Drawing.Size(61, 53);
            this.BtnCalendarizar.TabIndex = 20;
            this.BtnCalendarizar.UseVisualStyleBackColor = false;
            this.BtnCalendarizar.Click += new System.EventHandler(this.BtnCalendarizar_Click);
            // 
            // Calendarizar
            // 
            this.Calendarizar.AutoSize = true;
            this.Calendarizar.BackColor = System.Drawing.Color.Transparent;
            this.Calendarizar.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendarizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Calendarizar.Location = new System.Drawing.Point(132, 76);
            this.Calendarizar.Name = "Calendarizar";
            this.Calendarizar.Size = new System.Drawing.Size(91, 14);
            this.Calendarizar.TabIndex = 21;
            this.Calendarizar.Text = "Calendarizar";
            // 
            // BtnPredeterminado
            // 
            this.BtnPredeterminado.BackColor = System.Drawing.Color.Transparent;
            this.BtnPredeterminado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPredeterminado.BackgroundImage")));
            this.BtnPredeterminado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPredeterminado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPredeterminado.Location = new System.Drawing.Point(251, 20);
            this.BtnPredeterminado.Name = "BtnPredeterminado";
            this.BtnPredeterminado.Size = new System.Drawing.Size(61, 53);
            this.BtnPredeterminado.TabIndex = 22;
            this.BtnPredeterminado.TabStop = false;
            this.BtnPredeterminado.Click += new System.EventHandler(this.BtnPredeterminado_Click);
            // 
            // Predeterminado
            // 
            this.Predeterminado.AutoSize = true;
            this.Predeterminado.BackColor = System.Drawing.Color.Transparent;
            this.Predeterminado.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Predeterminado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Predeterminado.Location = new System.Drawing.Point(229, 76);
            this.Predeterminado.Name = "Predeterminado";
            this.Predeterminado.Size = new System.Drawing.Size(108, 14);
            this.Predeterminado.TabIndex = 23;
            this.Predeterminado.Text = "Predeterminado";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.BtnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.BackgroundImage")));
            this.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.Location = new System.Drawing.Point(359, 20);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(61, 53);
            this.BtnLimpiar.TabIndex = 24;
            this.BtnLimpiar.TabStop = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // LimiparPantalla
            // 
            this.LimiparPantalla.AutoSize = true;
            this.LimiparPantalla.BackColor = System.Drawing.Color.Transparent;
            this.LimiparPantalla.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimiparPantalla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LimiparPantalla.Location = new System.Drawing.Point(338, 76);
            this.LimiparPantalla.Name = "LimiparPantalla";
            this.LimiparPantalla.Size = new System.Drawing.Size(108, 14);
            this.LimiparPantalla.TabIndex = 25;
            this.LimiparPantalla.Text = "Limpiar Pantalla";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // BtnCargar
            // 
            this.BtnCargar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCargar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCargar.BackgroundImage")));
            this.BtnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCargar.Location = new System.Drawing.Point(45, 320);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(60, 48);
            this.BtnCargar.TabIndex = 26;
            this.BtnCargar.TabStop = false;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // BtnDetener
            // 
            this.BtnDetener.BackColor = System.Drawing.Color.Transparent;
            this.BtnDetener.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDetener.BackgroundImage")));
            this.BtnDetener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDetener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDetener.Location = new System.Drawing.Point(372, 320);
            this.BtnDetener.Name = "BtnDetener";
            this.BtnDetener.Size = new System.Drawing.Size(60, 48);
            this.BtnDetener.TabIndex = 27;
            this.BtnDetener.TabStop = false;
            this.BtnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEjecutar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEjecutar.BackgroundImage")));
            this.BtnEjecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEjecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEjecutar.Location = new System.Drawing.Point(216, 320);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(60, 48);
            this.BtnEjecutar.TabIndex = 28;
            this.BtnEjecutar.TabStop = false;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(338, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 14);
            this.label1.TabIndex = 29;
            this.label1.Text = "Detener Calendario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(180, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 14);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ejecutar Calendario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 14);
            this.label3.TabIndex = 31;
            this.label3.Text = "Cargar Calendario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Caledarizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(756, 415);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEjecutar);
            this.Controls.Add(this.BtnDetener);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.LimiparPantalla);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.Predeterminado);
            this.Controls.Add(this.BtnPredeterminado);
            this.Controls.Add(this.Calendarizar);
            this.Controls.Add(this.BtnCalendarizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnConexion);
            this.Controls.Add(this.PuertoList);
            this.Controls.Add(this.RTBx_Terminal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Caledarizacion";
            this.Text = "Calendarizacion";
            this.Load += new System.EventHandler(this.Caledarizacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPredeterminado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDetener)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEjecutar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBx_Terminal;
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
        private System.Windows.Forms.CheckBox ChBx_5;
        private System.Windows.Forms.CheckBox ChBx_4;
        private System.Windows.Forms.CheckBox ChBx_3;
        private System.Windows.Forms.CheckBox ChBx_2;
        private System.Windows.Forms.CheckBox ChBx_1;
        private System.Windows.Forms.Button BtnCalendarizar;
        private System.Windows.Forms.CheckBox ChBx_PeriodoMuestreo;
        private System.Windows.Forms.CheckBox ChBx_Duracion;
        private System.Windows.Forms.Label Calendarizar;
        private System.Windows.Forms.PictureBox BtnPredeterminado;
        private System.Windows.Forms.Label Predeterminado;
        private System.Windows.Forms.PictureBox BtnLimpiar;
        private System.Windows.Forms.Label LimiparPantalla;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox BtnCargar;
        private System.Windows.Forms.PictureBox BtnDetener;
        private System.Windows.Forms.PictureBox BtnEjecutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}