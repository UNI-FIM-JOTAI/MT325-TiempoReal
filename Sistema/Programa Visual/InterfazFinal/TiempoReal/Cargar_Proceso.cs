using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
            //  http://www.forosdelweb.com/f29/pasar-datos-entre-formulario-c-580382/
namespace TiempoReal
{
    public partial class Cargar_Proceso : Form
    {
        
        public Cargar_Proceso()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private string trama = "";
        
        public static string proceso_a_cargar;


        private void btnSalirc_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Close();
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "Nombre:  Direccion:" + "\n" + "\r" + " LED1   4096:  PROCESO 1" + "\n" + "\r" + " LED2   4166:  PROCESO 2" + "\n" + "\r" + " LED3   4242:  PROCESO 3" + "\n" + "\r" + " LED4   4312:  PROCESO 3" + "\n" + "\r" + " LED5   4382:  PROCESO 4" + "\n" + "\r" + " LED6   4592:  PROCESO 5" + "\n" + "\r" + " ADC1   4814:  Señal Analogica" + "\n" + "\r" + " ADC1   4896:  Contador N.I.";
                
                
              //  ("Direcciones: \n  LED 1: 4096\n  LED 2: 4192\n  LED 3: 4384\n  Leer ADC: 4896", "Tabla de Direcciones");
            // MessageBox.Show("Direcciones: \n  LED 1: 4096\n  LED 2: 4192\n  LED 3: 4384\n  Leer ADC: 4896", "Tabla de Direcciones"
              //  , MessageBoxButtons.OK, MessageBoxIcon.Question);
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Int32 tx = Int32.Parse(textBox1.Text);


       //     if (tx == 4096 || tx == 4166 || tx == 4242 || tx == 4312 || tx == 4382 || tx == 4592 || tx == 4814 || tx == 4896)
        //    { //  tx == 4192  tx = 4384 

                string name = textBox2.Text;
                tx = tx * 10 + 1;
                string enviar = tx.ToString();
                trama += enviar;
                name += "W";
                trama += name;
                // richTextBox1.AppendText(trama);
                serialPort1.Write(trama);
                trama = "";
         //   }
          //  else
          //  {
          //      MessageBox.Show("Use el boton HELP para obtener las direcciones correctas.");
         //   }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
           /* CheckForIllegalCrossThreadCalls = false;
            string dato = serialPort1.ReadExisting();
            if (dato == "m")
            {
                proceso_a_cargar = textBox1.Text;
                serialPort1.Write(proceso_a_cargar);
                textBox1.Clear();
            }
        */

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = DateTime.Now.ToLongTimeString();
        }
    }
}
