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
    public partial class Version : Form
    {
        #region DECLARACION DE VARIABLES

        private string data = "";
        private int j = 0;
        private string cmd;
        int cmd_num;
        int flag_cmd;
        string msg;

        #endregion

        public Version()
        {
            InitializeComponent();
            PuertoList.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                PuertoList.Items.Add(s);
                PuertoList.Text = s;
            }
            PuertoSerial.PortName = "COM1";
            BtnVersion.Enabled = false;
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
                BtnVersion.Enabled = true;

            }
        }

        private void BtnVersion_Click(object sender, EventArgs e)
        {
            msg = "$V1*";
            EnviarComando(msg);
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

        private void ProcesarComando(object s, EventArgs e)
        {
            TextoVersion.Text = data;
            data = "";
            flag_cmd = 1;
        }

        private void EnviarComando(string Enviardato)
        {
            int tam_s = 0;
            string temp_char;
            tam_s = Enviardato.Length;
            if (tam_s != 0)
            {
                for (int i = 1; i < tam_s; i++)
                {
                    temp_char = Enviardato.Remove(i);
                    temp_char = temp_char.Remove(0, i - 1);
                    PuertoSerial.Write(temp_char);
                    
                    Thread.Sleep(50);

                }
                temp_char = Enviardato.Remove(0, tam_s - 1);
                PuertoSerial.Write(temp_char);
            }

        }
    }
}
