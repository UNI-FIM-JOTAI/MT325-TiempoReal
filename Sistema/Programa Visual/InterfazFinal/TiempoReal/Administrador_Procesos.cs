using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiempoReal
{
    public partial class Administrador_Procesos : Form
    {

    #region INICIALIZACION
        public Administrador_Procesos()
        {
            InitializeComponent();
            serialPort1.Open();
            dataGridView1.Rows.Add(" ", " ", " ", " ", " ", " ", " ");
            dataGridView1.Rows.Add(" ", " ", " ", " ", " ", " ", " ");
            dataGridView1.Rows.Add(" ", " ", " ", " ", " ", " ", " ");
            dataGridView1.Rows.Add(" ", " ", " ", " ", " ", " ", " ");
            dataGridView1.Rows.Add(" ", " ", " ", " ", " ", " ", " ");
            dataGridView1.Rows.Add(" ", " ", " ", " ", " ", " ", " ");
            dataGridView1.Rows.Add(" ", " ", " ", " ", " ", " ", " ");
            
        }

    #endregion

    #region VARIABLES
               private  int close1 = 0;
               private int j = 0, k = 0;
               private double tiemp_eje;
               private UInt32 num;
              //  private UInt64 num;
               private string id, est, tiemp, nombre;
               private string dir_i , dir_a, quant;
               public string data = "";
    #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            if (close1 == 1)
            {
                Close();
            }
            else {
                MessageBox.Show(" Detenga el 'Administrador de procesos'  ");
            }
            
        }


        
        private void Actualizar(object s, EventArgs e)
        {
            char[] delimitadores = { '+' };
            string[] palabras = data.Split(delimitadores);
            j = 0;

            foreach (string s1 in palabras)
            {
                switch (j)
                {
                    case 0:
                        id = s1;
                        break;
                    case 1:
                        nombre = s1;
                        break;
                    case 2:
                        est = s1;
                        break;
                    case 3:
                        dir_i = s1;
                        break;
                    case 4:
                        dir_a = s1;
                        break;
                    case 5:
                        quant = s1;

                        k = Convert.ToInt32(id);
                        num = Convert.ToUInt32(quant);
                        // num = Convert.ToUInt64(quant);
                        // num = Convert.ToInt32(quant);
                        tiemp_eje = 0.007 * num;
                        tiemp = tiemp_eje.ToString();

                        dataGridView1.Rows[k - 1].Cells[0].Value = id;
                        dataGridView1.Rows[k - 1].Cells[1].Value = nombre;
                        dataGridView1.Rows[k - 1].Cells[2].Value = est;
                        dataGridView1.Rows[k - 1].Cells[3].Value = dir_i;
                        dataGridView1.Rows[k - 1].Cells[4].Value = dir_a;
                        dataGridView1.Rows[k - 1].Cells[5].Value = quant;
                        dataGridView1.Rows[k - 1].Cells[6].Value = tiemp;
                        //k = k + 1;
                        num = 0;
                        break;
                }
                j = j + 1;

            }
            data = "";
        }

         
        private void Cerrar1(object s, EventArgs e) {
            serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            data += serialPort1.ReadExisting();
            data = data.ToString();
            if (data.EndsWith("\r\n"))    // estoy esperando el fin de la trama
            {
                data = data.Remove(data.Length - 2);  // le saco los caracteres de fin de trama, quizas necesitas hacer otras cosas, te pongo un ejemplo simple
                this.Invoke(new EventHandler(Actualizar));

            }
            // this.Invoke(new EventHandler(Actualizar));
            

            if (close1 == 1)
            {
                // this.Invoke(new EventHandler(Cerrar1));
                serialPort1.Close();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("4W");
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            serialPort1.Write("4W");
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            close1 = 1;
            timer1.Stop();
        }
    }
}
