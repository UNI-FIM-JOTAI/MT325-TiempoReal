using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;


namespace TiempoReal
{
    public partial class Version_SO : Form
    {
        public Version_SO()
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

        private string trama1 = "";
        public string data = ""; 

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            trama1 = "";
            trama1 += "3";
            trama1 += "W";
            PuertoSerial.Write(trama1);
            trama1 = "";
            // this.richTextBox1.Clear();
            // this.richTextBox1.Text = "SISTEMA OPERATIVO Version 3.1\n";
            // this.richTextBox1.AppendText(trama1);
            // richTextBox1.AppendText(trama1);
            data = "version 3.0";
            TxBx_Version.Text = Convert.ToString(data);

        }

        private void Actualizar(object s, EventArgs e)
        {
            data = "version 3.0";
            TxBx_Version.Text = Convert.ToString(data);

          //  textBoxTMP.Text = RecibirDato; // Muestra los datos recibidos en el TextBox
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
             data += PuertoSerial.ReadExisting();
            data = data.ToString(); 
            // MessageBox.Show(data); 
            this.Invoke(new EventHandler(Actualizar));
        }

        private void SO_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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

            }
        }
    }
}
