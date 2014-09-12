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
        string[] datos = new string[100];
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
            serialPort1.Write("V");
            Enviado.Text = "V";
            i++;
            lista_Enviado.TabIndex = i + 1;
            lista_Enviado.AppendText("V" + " ");
            flag = 1;
        }

        private void corriente_Click(object sender, EventArgs e)//mostrar
        {
            serialPort1.Write("A");
            Enviado.Text = "A";
            i++;
            lista_Enviado.TabIndex = i + 1;
            lista_Enviado.AppendText("A" + " ");
            flag = 2;
            //int i;           
            //lista_Recibido.Clear();            
            //    for (i = 0; i < c; i++)
            //    {
            //
            //        lista_Recibido.TabIndex = i + 1;
            //        lista_Recibido.AppendText(datos[i] + " ");
            //
            //    }                
            
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            f = 1;
            rx = serialPort1.ReadExisting();
            Recibido.Text = rx;
            r++;
            lista_Recibido.TabIndex = r + 1;
            lista_Recibido.AppendText(rx + " ");
            if (rx == "*")
            {
                Thread.Sleep(10);
                serialPort1.Write("B");
                i++;
                lista_Enviado.TabIndex = i + 1;
                lista_Enviado.AppendText("B" + " ");
                Thread.Sleep(10000);
                serialPort1.Write("@");
                i++;
                lista_Enviado.TabIndex = i + 1;
                lista_Enviado.AppendText("@" + " ");
                lec = 1; f = 0;
            }
            if (lec == 1 && f != 0)
            {
                temp1 = Convert.ToInt16(rx[0]);
                Thread.Sleep(10000);
                serialPort1.Write("@");
                i++;
                lista_Enviado.TabIndex = i + 1;
                lista_Enviado.AppendText("@" + " ");
                lec = 2; f = 0;
            }
            if (lec == 2 && f != 0)
            {
                f = 0;
                temp2 = Convert.ToInt16(rx[0]);
                tempgen = temp2 + (temp1 * 256);
                datos[c] = Convert.ToString(tempgen);

                i++;
                lista_Enviado.TabIndex = i + 1;
                lista_Enviado.AppendText("@" + " ");
                if (flag == 1)
                {
                    Velocidad.Text = datos[c];
                    r++;
                    lista_Recibido.TabIndex = r + 1;
                    lista_Recibido.AppendText(datos[c] + " ");
                }
                if (flag == 2)
                {
                    Corriente.Text = datos[c];
                    r++;
                    lista_Recibido.TabIndex = r + 1;
                    lista_Recibido.AppendText(datos[c] + " ");
                }
                flag = 0;
                c++; lec = 1;
                serialPort1.Write("@");
                i++;
                lista_Enviado.TabIndex = i + 1;
                lista_Enviado.AppendText("@" + " ");
            }

            //if (c == 100)
            //{
            //    c = 0;
            //}
        }

        private void cw_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
            Enviado.Text = "1";
            i++;
            lista_Enviado.TabIndex = i + 1;
            lista_Enviado.AppendText("1" + " ");
        }

        private void ccw_Click(object sender, EventArgs e)
        {
            serialPort1.Write("2");
            Enviado.Text = "2";
            i++;
            lista_Enviado.TabIndex = i + 1;
            lista_Enviado.AppendText("2" + " ");
        }

        private void stop_Click(object sender, EventArgs e)
        {
            serialPort1.Write("3");
            Enviado.Text = "3";
            i++;
            lista_Enviado.TabIndex = i + 1;
            lista_Enviado.AppendText("3" + " ");
        }

        private void Puertos_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = Puertos.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
