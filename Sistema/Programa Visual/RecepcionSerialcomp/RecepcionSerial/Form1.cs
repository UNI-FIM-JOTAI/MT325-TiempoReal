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
        string temp_char;
        string mostrar_envio;
        int tam_s;
        int num_list = 0;

        
        
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


        private void extract_send()
        {
            tam_s = Enviardato.Length;
            for (int i = tam_s-1; i >=0;i--)
            {
                temp_char = Enviardato.Remove(0, i);
                serialPort1.Write(temp_char);
                Enviardato = Enviardato.Remove(i);
                
            }
        }
        private void Recibir(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
           // Recibirdato = "";
            Recibirdato += this.serialPort1.ReadExisting();              
            this.Invoke(new EventHandler(actualizar));
        }

        private void actualizar (object sender, EventArgs e)
        {   
            //int IniAN0 = Recibirdato.IndexOf("w");
            //int FiAN0 = Recibirdato.IndexOf("x");
            int Tamanio;
            Tamanio = Recibirdato.Length;
            //if (Recibirdato.Length > 5)
            //{
            //Recibirdato = "";
            //}
            //Monitor.Text = "";
            //Monitor.Text = ("dato recibido = " + Recibirdato + " posicion de la w en " + IniAN0 + "posición de la x en " + FiAN0 + "longitud del texto = " + Tamanio);
           
            Monitor.Text = "";
            Monitor.Text = (Recibirdato);

            
            //textBox4.Text = Tamanio.ToString();   
            textBox4.Text = Convert.ToString(Tamanio);  
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
            Recibirdato = "";
            //serialPort1.Open(); //ya estaba abierto el puerto :p
            Enviardato = (Convert.ToString(textBox1.Text));
            mostrar_envio = Enviardato;
            //serialPort1.Write(Enviardato.Remove(0,2));//this we are sending by RS232
                //
                tam_s = Enviardato.Length;
                if (tam_s != 0)
                {
                    for (int i = 1; i < tam_s; i++)
                    {
                        temp_char = Enviardato.Remove(i);
                        temp_char = temp_char.Remove(0, i - 1);
                        serialPort1.Write(temp_char);
                        Thread.Sleep(200);

                    }
                    temp_char = Enviardato.Remove(0, tam_s - 1);
                    serialPort1.Write(temp_char);
                    if (Monitor.Text.Length != 0)
                    {
                        listBox1.Items.Insert(num_list, Convert.ToString(Monitor.Text));
                        num_list++;
                    }
                }
                //
            textBox2.Text = (mostrar_envio);
            textBox3.Text = (Convert.ToString(mostrar_envio.Length));
            //textBox1.Text = (Convert.ToString(0x02));//now we will see what we be sent to the  pic
           // serialPort1.Close();
                      
         }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //solo para redacción
            
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Monitor_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    




        }

        
    }

