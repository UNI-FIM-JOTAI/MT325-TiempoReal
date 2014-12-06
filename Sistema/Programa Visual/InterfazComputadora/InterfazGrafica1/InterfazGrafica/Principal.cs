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
    public partial class Principal : Form
    {
        #region VARIABLES
        private string data = "";

        #endregion

        public Principal()
        {
            InitializeComponent();
            //PuertoList.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
            //    PuertoList.Items.Add(s);
            //    PuertoList.Text = s;
            }
            PuertoSerial.PortName = "COM1";
        }

        private void BtnConexion_Click(object sender, EventArgs e)
        {
            if (!PuertoSerial.IsOpen)
            {
               // PuertoSerial.PortName = PuertoList.Text;
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
                MessageBox.Show("Puerto conectado con exito.", "Exito en la conexión.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void BtnCalendarizacion_Click(object sender, EventArgs e)
        {
            Caledarizacion frm1 = new Caledarizacion();
            frm1.Show();

        }

        private void PuertoList_SelectedIndexChanged(object sender, EventArgs e)
        {
           // PuertoSerial.PortName = PuertoList.Text;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void PuertoSerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data += PuertoSerial.ReadExisting();
            data = data.ToString();
            if (data.EndsWith("*")) 
            {
                data = data.Remove(data.Length - 1);
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCargaDescarga_Click(object sender, EventArgs e)
        {
            CargaDescarga fmr2 = new CargaDescarga();
            fmr2.Show();
        }

        private void Terminal_Click(object sender, EventArgs e)
        {

        }

        private void BtnTerminal_Click(object sender, EventArgs e)
        {
            Terminal fmr3 = new Terminal();
            fmr3.Show();
        }

        private void BtnAdmProcesos_Click(object sender, EventArgs e)
        {
            AdmProcesos fmr4 = new AdmProcesos();
            fmr4.Show();
        }
    }
}
