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
    public partial class LecturaADC : Form
    {

        #region CREACION DE VARIABLES
            private Graphics g;
            private int [,] Linea = new int [3000,2];
            private int [] contPunto = new int[2];
            private int nPuntos = 50;
            private int ancho = 450, alto = 325;
            private int[] activo = new int[2];

            private string data = "";
            private int j = 0;
            private string cmd;
            int cmd_num;
            int flag_cmd=0;
            int flag_punto=0;
            int estado_conexion = 0;
            int valor = 0;
            
        #endregion
        public LecturaADC()
        {
            InitializeComponent();
            PuertoList.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                PuertoList.Items.Add(s);
                PuertoList.Text = s;
            }
            PuertoSerial.PortName = "COM1";
            Timer.Enabled = true;
            g = PBx_Monitor.CreateGraphics();
            contPunto[0] = 0;
            contPunto[1] = 0;
            activo[0] = 1;
            activo[1] = 1;
            PBx_Monitor.Image = null;
            
        }

        private void BtnVerGraficas_Click(object sender, EventArgs e)
        {
            contPunto[0] = 0;
            contPunto[1] = 0;
            ActualizarGrafica();
        }

        private void AgregarPunto(int valor, int linea)
        {
            if (contPunto[linea] == nPuntos)
            {
                for (int i = 0; i < nPuntos - 1; i++)
                {
                    Linea[i, linea] = Linea[i + 1, linea];
                }
                Linea[nPuntos - 1, linea] = valor;
            }
            else
            {
                Linea[contPunto[linea], linea] = valor;
                contPunto[linea]++;
            }
        }

        private void ActualizarGrafica() {
            g.Clear(PBx_Monitor.BackColor);     // Limpia la pantalla PBxMonitor

            if (activo[0] == 1)
            {
                GraficarPuntos(0);
            }
            if (activo[1] == 1)
            {
                GraficarPuntos(1);
            }
        }

        private void GraficarPuntos(int linea)
        {
            int incremento= ancho/nPuntos;
            if (contPunto[linea] > 1)
            {
                for (int i = 0; i < contPunto[linea]-1; i++)
                {
                    g.DrawLine(Pens.Blue , (i*incremento), alto - Linea[i,linea], ((i+1)*incremento),alto - Linea[i+1,linea] );
                }
            }
        }

        private void BtnConexion_Click(object sender, EventArgs e)
        {
            if (estado_conexion == 0)
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
                    estado_conexion = 1;
                    LConexion.Text = "Desconectar";
                }
            }
            else
            {
                PuertoSerial.Close();
                if (PuertoSerial.IsOpen)
                {
                    MessageBox.Show("No se ha podido desconectar.", "Error en desconexion.",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Puerto " + PuertoList.Text + " desconectado con exito.", "Exito en la desconexión.",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    estado_conexion = 0;
                    LConexion.Text = "Conectar";
                }
            }
        }

        private void PuertoSerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data += PuertoSerial.ReadExisting();
            data = data.ToString();
            if (data.EndsWith("*"))
            {
                data = data.Remove(data.Length - 1);
                this.Invoke(new EventHandler(ProcesarComando));
            }
        }

        private void ProcesarComando(object s, EventArgs e)
        {
            char[] delimitadores = { '+' };
            string[] palabras = data.Split(delimitadores);
            j = 0;
            foreach (string s1 in palabras)
            {
                switch (j)
                {
                    case 0:
                        cmd = s1;
                        break;
                    case 1:
                        cmd_num = Convert.ToInt16(s1);
                        break;
                    case 2:
                        valor = Convert.ToInt16(s1);
                        break;
                }
                j = j + 1;
            }
            data = "";
            flag_cmd = 1;

        }

        private void EnviarComando(string Enviardato)
        {
            int tam_s = 0;
            string temp_char;
            tam_s = Enviardato.Length;
            if (tam_s != 0)
            {
                for (int i = 1; i < tam_s; i++)
                {
                    temp_char = Enviardato.Remove(i);
                    temp_char = temp_char.Remove(0, i - 1);
                    PuertoSerial.Write(temp_char);
                    Thread.Sleep(50);

                }
                temp_char = Enviardato.Remove(0, tam_s - 1);
                PuertoSerial.Write(temp_char);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (flag_cmd == 1)
            {

                switch (cmd)
                {
                    case "A":
                        AgregarPunto(valor, cmd_num);
                        flag_punto = 1;
                        break;
                    case "D":
                        
                        break;
                }
                flag_cmd = 0;
            }
            if (flag_punto == 1)
            {
                ActualizarGrafica();
                flag_punto = 0;
            }
        }

    }
}
