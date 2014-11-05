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

namespace TiempoReal
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

     
     
        private void label1_Click(object sender, EventArgs e)
        {

        }


     

    
        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cargar_Proceso frm2 = new Cargar_Proceso();

            frm2.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Descargar_Proceso frm3 = new Descargar_Proceso();
            frm3.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Administrador_Procesos frm4 = new Administrador_Procesos();
            frm4.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ayuda frm6 = new Ayuda();
            frm6.Show();
            
         }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            Version_SO frm_7 = new Version_SO();
            frm_7.Show();
         
            // MessageBox.Show("Sistema Operativo Multitarea V. 2.0", "Sistema Operativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Calendario_main frm7 = new Calendario_main();
            frm7.Show();
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            LecturaADC frm9 = new LecturaADC();
            frm9.Show();

        }
    }
}
