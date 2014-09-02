using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;


namespace RecepcionSerial
{
    public partial class Form1 : Form
    {
        string Recibirdato;
        string Enviardato;
        public Form1()
        {
            InitializeComponent();
            if(!serialPort1.IsOpen)
            {try
                {
                    serialPort1.Open();
                
            }
                catch(System.Exception ex)
            {
                    MessageBox.Show(ex.Message);
                }
            }

            //serialPort1.DataReceived+= new System.IO.Ports.SerialDataReceivedEventHandler(this.Recibir);
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Recibir);
        }
        private void Recibir(object sender,System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Recibirdato += this.serialPort1.ReadExisting();
            this.Invoke(new EventHandler(actualizar));
        }
        private void actualizar (object sender, EventArgs e)
        {   
            int IniAN0 = Recibirdato.IndexOf("w");
            int FiAN0 = Recibirdato.IndexOf("x");
            int Tamanio = Recibirdato.Length;
            //if (Recibirdato.Length > 5)
            //{
            //Recibirdato = "";
            //}
            //Monitor.Text = "";
            //Monitor.Text = ("dato recibido = " + Recibirdato + " posicion de la w en " + IniAN0 + "posición de la x en " + FiAN0 + "longitud del texto = " + Tamanio);
           
            Monitor.Text = "";
            Monitor.Text = ("dato recibido = " + Recibirdato);
            
               
            
            //Monitor.Text = Recibirdato;
            //Recibirdato = "";
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //serialPort1.Open(); //ya estaba abierto el puerto :p
            serialPort1.Write(Enviardato);//this we are sending by RS232
            textBox2.Text = (Enviardato);
            //textBox1.Text = (Convert.ToString(0x02));//now we will see what we be sent to the  pic
           // serialPort1.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Enviardato = (Convert.ToString(textBox1.Text));
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

        }

    




        }

        
    }

