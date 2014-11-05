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
using System.IO;


namespace TiempoReal
{
    public partial class Version_SO : Form
    {
        public Version_SO()
        {
            InitializeComponent();
            serialPort1.Open();
            // serialPort1.DataReceived += new
           //  System.IO.Ports.SerialDataReceivedEventHandler(Recibir); //Si hay datos recibidos, llamar a (Recibir)
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
            serialPort1.Write(trama1);
            trama1 = "";
            // this.richTextBox1.Clear();
            // this.richTextBox1.Text = "SISTEMA OPERATIVO Version 3.1\n";
            // this.richTextBox1.AppendText(trama1);
            // richTextBox1.AppendText(trama1);

        }

        private void Actualizar(object s, EventArgs e)
        {
            this.richTextBox1.Text = data;

          //  textBoxTMP.Text = RecibirDato; // Muestra los datos recibidos en el TextBox
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
             data += serialPort1.ReadExisting();
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
    }
}
