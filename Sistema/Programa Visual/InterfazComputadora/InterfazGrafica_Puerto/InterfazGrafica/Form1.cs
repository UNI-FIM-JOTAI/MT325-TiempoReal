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
    public partial class Form1 : Form
    {
        public Form1()
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
