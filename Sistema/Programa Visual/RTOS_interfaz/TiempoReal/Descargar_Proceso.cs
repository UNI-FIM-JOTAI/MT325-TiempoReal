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
    public partial class Descargar_Proceso : Form
    {
        public Descargar_Proceso()
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

     #region VARIABLES
        // private int close1 = 0;
        private int j = 0, k = 0;
        private double tiemp_eje;
        private Int32 num;
        private string id, est, tiemp, nombre;
        private string dir_i, dir_a, quant;
        private string data = "";
     #endregion


        private string mitrama ="";
        



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //serialPort1.Close();
            Close();
        }

        private void Actualizar(object s, EventArgs e)
        {
            // this.richTextBox1.Text = data;
            
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
                        num = Convert.ToInt32(quant);
                        tiemp_eje = 0.25 * num;
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



        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
                       
            data += serialPort1.ReadExisting();
            data = data.ToString();

            if (data.EndsWith("\r\n"))    // estoy esperando el fin de la trama
            {
                data = data.Remove(data.Length - 2);  // le saco los caracteres de fin de trama, quizas necesitas hacer otras cosas, te pongo un ejemplo simple
                this.Invoke(new EventHandler(Actualizar));

            }

            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu menu = new ContextMenu();
                menu.MenuItems.Add(new MenuItem("Descargar"));
            }
        }

        public string Fila,Col;
        

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                Fila = e.RowIndex.ToString();
                Col = e.ColumnIndex.ToString();
                
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell ClickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];

                    this.dataGridView1.CurrentCell = ClickedCell;

                    var PosicionMouse = dataGridView1.PointToClient(Cursor.Position);
                    

                   this.contextMenuStrip1.Show(dataGridView1, PosicionMouse);

                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            
            var PosicionMouse = dataGridView1.PointToClient(Cursor.Position);
            string id;
            int fila2;
            fila2 = Convert.ToInt32(Fila);
            id = dataGridView1.Rows[fila2].Cells[0].Value.ToString();
            //id3 es un string que contine el ID!!
             contextMenuStrip1.Close();
            MessageBox.Show(id,"Descargar Proceso con ID:");
        }

        private void Descargar_Proceso_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = DateTime.Now.ToLongTimeString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mitrama = "";
            mitrama += "4";
            mitrama += "W";
            serialPort1.Write(mitrama);
            mitrama = "";
            // this.richTextBox1.Text = "\n ID  -  Dir. Inicio  - Estado  -  Tiempo  - Nombre \n \r";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            if (txt == "")
            {
                MessageBox.Show("Ingrese el ID para poder \n dercargar el proceso ");
            }
            else
            {

                Int32 tx1 = Int32.Parse(textBox1.Text);

                tx1 = tx1 * 10 + 2;
                string enviar1 = tx1.ToString();
                enviar1 += "W";
                mitrama += enviar1;
                serialPort1.Write(mitrama);
                mitrama = "";
            }
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //var PosicionMouse = dataGridView1.PointToClient(Cursor.Position);
            string name;
            string id1;
            int fila2;
            fila2 = Convert.ToInt32(Fila);
            id1 = dataGridView1.Rows[fila2].Cells[0].Value.ToString();
            name = dataGridView1.Rows[fila2].Cells[1].Value.ToString();
            //id3 es un string que contine el ID!!
            contextMenuStrip1.Close();
            MessageBox.Show(" Realmente desea descargar \n el proceso ' " + name + " ' con ID:  ' " + id1 + " ' ? \n");

            Int32 tx = Convert.ToInt32(id1);
            tx = tx * 10 + 2;
            string enviar = tx.ToString();
            enviar += "W";
            mitrama += enviar;
            serialPort1.Write(enviar);
            mitrama = "";
        }

        private void contextMenuStrip1_MouseClick_1(object sender, MouseEventArgs e)
        {
           

        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string enviar2 = "4W";
            mitrama += enviar2;
            serialPort1.Write(mitrama);
            mitrama = "";
        }

    }
}
