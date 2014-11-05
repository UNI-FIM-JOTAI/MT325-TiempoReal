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

namespace dsp
{
    public partial class Form1 : Form
    {
        string rx;
        int f;
        int i = 0;
        int r = 0;
        int temp1;
        int temp2;
        int tempgen;
        int c = 0;
        int lec = 0;
        int flag = 0;
        int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
        string[] datos = new string[100];

        string Recibirdato;
        string Enviardato;
        string temp_char;
        string mostrar_envio;
        int tam_s;
        int num_list = 0;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            groupBox1.Enabled = false;
            Control.CheckForIllegalCrossThreadCalls = false;
            foreach (string s in SerialPort.GetPortNames())
            {
                Puertos.Items.Add(s);
                Puertos.Text = s;
            }
            serialPort1.PortName = "COM1";
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
        }

        private void extract_send()
        {
            tam_s = Enviardato.Length;
            for (int i = tam_s - 1; i >= 0; i--)
            {
                temp_char = Enviardato.Remove(0, i);
                serialPort1.Write(temp_char);
                Enviardato = Enviardato.Remove(i);

            }
        }

        private void actualizar(object sender, EventArgs e)
        {
            Recibido.Text = "";
            Recibido.Text = (Recibirdato);
            if (Recibido.Text.Length != 0)
            {
                listBox1.Items.Insert(num_list, Convert.ToString(Recibido.Text));
                num_list++;
            }
        }

        private void conectar_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.Open();
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("No hay un puerto abierto.", "Error de conexión.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Puerto " + Puertos.Text + " conectado con exito.", "Exito en la conexión.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                groupBox1.Enabled = true;
            }
        }

        private void velocidad_Click(object sender, EventArgs e)//iniciar
        {
            if (p3 == 0)
            {
                serialPort1.Write("$");
                Thread.Sleep(200);
                serialPort1.Write("C");
                Thread.Sleep(200);
                serialPort1.Write("2");
                Thread.Sleep(200);
                serialPort1.Write("*");
                Thread.Sleep(200);
                Enviado.Text = "$C2*";
                p3 = 1;
            }
            else
            {
                serialPort1.Write("$");
                Thread.Sleep(200);
                serialPort1.Write("D");
                Thread.Sleep(200);
                serialPort1.Write("2");
                Thread.Sleep(200);
                serialPort1.Write("*");
                Thread.Sleep(200);
                Enviado.Text = "$D2*";
                p3 = 0;

            }
            i++;
            lista_Enviado.TabIndex = i + 1;
            lista_Enviado.AppendText("3" + " ");
            flag = 1;
        }

        private void corriente_Click(object sender, EventArgs e)//mostrar
        {
            if (p4 == 0)
            {
                serialPort1.Write("$");
                Thread.Sleep(200);
                serialPort1.Write("C");
                Thread.Sleep(200);
                serialPort1.Write("3");
                Thread.Sleep(200);
                serialPort1.Write("*");
                Thread.Sleep(200);
                Enviado.Text = "$C3*";
                p4 = 1;
            }
            else
            {
                serialPort1.Write("$");
                Thread.Sleep(200);
                serialPort1.Write("D");
                Thread.Sleep(200);
                serialPort1.Write("3");
                Thread.Sleep(200);
                serialPort1.Write("*");
                Thread.Sleep(200);
                Enviado.Text = "$D3*";
                p4 = 0;

            }
            i++;
            lista_Enviado.TabIndex = i + 1;
            lista_Enviado.AppendText("4" + " ");
            flag = 2;               
            
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // Recibirdato = "";
            Recibirdato += this.serialPort1.ReadExisting();
            this.Invoke(new EventHandler(actualizar));
        }

        private void cw_Click(object sender, EventArgs e)
        {
            if (p1 == 0)
            {
                serialPort1.Write("$");
                Thread.Sleep(200);
                serialPort1.Write("C");
                Thread.Sleep(200);
                serialPort1.Write("0");
                Thread.Sleep(200);
                serialPort1.Write("*");
                Thread.Sleep(200);
                Enviado.Text = "$C0*";
                p1 = 1;
            }
            else {
                serialPort1.Write("$");
                Thread.Sleep(200);
                serialPort1.Write("D");
                Thread.Sleep(200);
                serialPort1.Write("0");
                Thread.Sleep(200);
                serialPort1.Write("*");
                Thread.Sleep(200);
                Enviado.Text = "$D0*";
                p1 = 0;
                
            }
            i++;
            lista_Enviado.TabIndex = i + 1;
            lista_Enviado.AppendText("1" + " ");
        }

        private void ccw_Click(object sender, EventArgs e)
        {
            if (p2 == 0)
            {
                serialPort1.Write("$");
                Thread.Sleep(200);
                serialPort1.Write("C");
                Thread.Sleep(200);
                serialPort1.Write("1");
                Thread.Sleep(200);
                serialPort1.Write("*");
                Thread.Sleep(200);
                Enviado.Text = "$C1*";
                p2 = 1;
            }
            else
            {
                serialPort1.Write("$");
                Thread.Sleep(200);
                serialPort1.Write("D");
                Thread.Sleep(200);
                serialPort1.Write("1");
                Thread.Sleep(200);
                serialPort1.Write("*");
                Thread.Sleep(200);
                Enviado.Text = "$D1*";
                p2 = 0;

            }
            i++;
            lista_Enviado.TabIndex = i + 1;
            lista_Enviado.AppendText("2" + " ");
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (p5 == 0)
            {
                serialPort1.Write("$");
                Thread.Sleep(200);
                serialPort1.Write("C");
                Thread.Sleep(200);
                serialPort1.Write("4");
                Thread.Sleep(200);
                serialPort1.Write("*");
                Thread.Sleep(200);
                Enviado.Text = "$C4*";
                p5 = 1;
            }
            else
            {
                serialPort1.Write("$");
                Thread.Sleep(200);
                serialPort1.Write("D");
                Thread.Sleep(200);
                serialPort1.Write("4");
                Thread.Sleep(200);
                serialPort1.Write("*");
                Thread.Sleep(200);
                Enviado.Text = "$D4*";
                p5 = 0;

            }
            i++;
            lista_Enviado.TabIndex = i + 1;
            lista_Enviado.AppendText("5" + " ");
        }

        private void Puertos_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = Puertos.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lista_Recibido_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
