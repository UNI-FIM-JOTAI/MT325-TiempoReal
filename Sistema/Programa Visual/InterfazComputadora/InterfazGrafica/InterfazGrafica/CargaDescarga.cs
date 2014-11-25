using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace InterfazGrafica
{
    public partial class CargaDescarga : Form
    {

        #region VARIABLES
        private string data = "";
        private int j = 0, k = 0;
        private string cmd,cmd_num;

        #endregion

        public CargaDescarga()
        {
            InitializeComponent();
            PuertoList.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                    PuertoList.Items.Add(s);
                    PuertoList.Text = s;
            }
            PuertoSerial.PortName = "COM1";
        }

        private void CargaDescarga_Load(object sender, EventArgs e)
        {
            #region DESHABILITANDO_BOTONES
                Btn_Cargar1.Enabled = false;
                Btn_Cargar2.Enabled = false;
                Btn_Cargar3.Enabled = false;
                Btn_Cargar4.Enabled = false;
                //Btn_Cargar5.Enabled = false;

                Btn_Descargar1.Enabled = false;
                Btn_Descargar2.Enabled = false;
                //Btn_Descargar3.Enabled = false;
                //Btn_Descargar4.Enabled = false;
                //Btn_Descargar5.Enabled = false;
            #endregion

        }

        private void BtnConexion_Click(object sender, EventArgs e)
        {
            if (!PuertoSerial.IsOpen)
            {
                PuertoSerial.PortName = PuertoList.Text;
            }
            PuertoSerial.Close();
            PuertoSerial.Open();
            if (!PuertoSerial.IsOpen)
            {
                MessageBox.Show("No hay un puerto abierto.", "Error de conexión.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Puerto " + PuertoList.Text + " conectado con exito.", "Exito en la conexión.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                #region HABILITANDO_BOTONES_CARGA
                Btn_Cargar1.Enabled = true;
                Btn_Cargar2.Enabled = true;
                Btn_Cargar3.Enabled = true;
                Btn_Cargar4.Enabled = true;
                //Btn_Cargar5.Enabled = true;

                #endregion

            }
        }

        private void PuertoSerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data += PuertoSerial.ReadExisting();
            data = data.ToString();
            if (data.EndsWith("*"))
            {
                data = data.Remove(data.Length - 1);
                this.Invoke(new EventHandler(ProcesarComando));
            }
        }

        private void ProcesarComando(object s, EventArgs e) {
            char[] delimitadores = { '+' };
            string[] palabras = data.Split(delimitadores);
            j = 0;
            foreach (string s1 in palabras)
            {
                switch (j)
                {
                    case 0:
                        cmd = s1;
                        break;
                    case 1:
                        cmd_num = s1;
                        break;
                }
                j = j + 1;
            }
            data = "";
        }

        private void Btn_Cargar1_Click(object sender, EventArgs e)
        {
            PuertoSerial.Write("$C0*");
            Btn_Cargar1.Enabled = false;
            Btn_Descargar1.Enabled = true;
        }

        private void Btn_Descargar1_Click(object sender, EventArgs e)
        {
            PuertoSerial.Write("$D0*");
            Btn_Cargar1.Enabled = true;
            Btn_Descargar1.Enabled = false;
        }

        private void Btn_Cargar2_Click(object sender, EventArgs e)
        {
            PuertoSerial.Write("$C1*");
            Btn_Cargar2.Enabled = false;
            Btn_Descargar2.Enabled = true;
        }

        private void Btn_Descargar2_Click(object sender, EventArgs e)
        {
            PuertoSerial.Write("$D1*");
            Btn_Cargar2.Enabled = true;
            Btn_Descargar2.Enabled = false;
        }

        private void Btn_Cargar3_Click(object sender, EventArgs e)
        {
            PuertoSerial.Write("$C2*");
            Btn_Cargar3.Enabled = false;
            //Btn_Descargar3.Enabled = true;
        }

        private void Btn_Descargar3_Click(object sender, EventArgs e)
        {
            PuertoSerial.Write("$D2*");
            Btn_Cargar3.Enabled = true;
            //Btn_Descargar3.Enabled = false;
        }

        private void Btn_Cargar4_Click(object sender, EventArgs e)
        {
            PuertoSerial.Write("$C3*");
            Btn_Cargar4.Enabled = false;
            //Btn_Descargar4.Enabled = true;
        }

        private void Btn_Descargar4_Click(object sender, EventArgs e)
        {
            PuertoSerial.Write("$D3*");
            Btn_Cargar4.Enabled = true;
            //Btn_Descargar4.Enabled = false;
        }

        private void Btn_Cargar5_Click(object sender, EventArgs e)
        {
            PuertoSerial.Write("$C4*");
            //Btn_Cargar5.Enabled = false;
            //Btn_Descargar5.Enabled = true;
        }

        private void Btn_Descargar5_Click(object sender, EventArgs e)
        {
            PuertoSerial.Write("$D4*");
            //Btn_Cargar5.Enabled = true;
            //Btn_Descargar5.Enabled = false;
        }

        private void PuertoList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
