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
    public partial class CargaDescarga : Form
    {

        #region VARIABLES
        private string data = "";
        private int j = 0;
        private string cmd;
        int cmd_num;
        int flag_cmd;
        string msg;
        int[] procesos = {1,2,4,5 };
        int estado_conexion;

        #endregion

        public CargaDescarga()
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
        }

        private void CargaDescarga_Load(object sender, EventArgs e)
        {
            #region DESHABILITANDO_BOTONES
                Btn_Cargar1.Enabled = false;
                Btn_Cargar2.Enabled = false;
                Btn_Cargar3.Enabled = false;
                Btn_Cargar4.Enabled = false;
                //Btn_Cargar5.Enabled = false;

                Btn_Descargar1.Enabled = false;
                Btn_Descargar2.Enabled = false;
                //Btn_Descargar3.Enabled = false;
                //Btn_Descargar4.Enabled = false;
                //Btn_Descargar5.Enabled = false;
            #endregion

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
                    #region HABILITANDO_BOTONES_CARGA
                    Btn_Cargar1.Enabled = true;
                    Btn_Cargar2.Enabled = true;
                    Btn_Cargar3.Enabled = true;
                    Btn_Cargar4.Enabled = true;
                    //Btn_Cargar5.Enabled = true;

                    #endregion
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
                    #region DESHABILITANDO_BOTONES_CARGA
                    Btn_Cargar1.Enabled = false;
                    Btn_Cargar2.Enabled = false;
                    Btn_Cargar3.Enabled = false;
                    Btn_Cargar4.Enabled = false;
                    //Btn_Cargar5.Enabled = true;

                    #endregion
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

        private void ProcesarComando(object s, EventArgs e) {
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

        private void Btn_Cargar1_Click(object sender, EventArgs e)
        {
            msg = "$C" + procesos[0] + "*";
            EnviarComando(msg);
        }

        private void Btn_Descargar1_Click(object sender, EventArgs e)
        {
            msg = "$D" + procesos[0] + "*";
            EnviarComando(msg);
        }

        private void Btn_Cargar2_Click(object sender, EventArgs e)
        {
            msg = "$C" + procesos[1] + "*";
            EnviarComando(msg);
        }

        private void Btn_Descargar2_Click(object sender, EventArgs e)
        {
            msg = "$D" + procesos[1] + "*";
            EnviarComando(msg);
        }

        private void Btn_Cargar3_Click(object sender, EventArgs e)
        {
            msg = "$C" + procesos[2] + "*";
            EnviarComando(msg);
        }

        private void Btn_Descargar3_Click(object sender, EventArgs e)
        {
            msg = "$D" + procesos[2] + "*";
            EnviarComando(msg);
        }

        private void Btn_Cargar4_Click(object sender, EventArgs e)
        {
            msg = "$C" + procesos[3] + "*";
            EnviarComando(msg);
        }

        private void Btn_Descargar4_Click(object sender, EventArgs e)
        {
            msg = "$D" + procesos[3] + "*";
            EnviarComando(msg);
        }

        private void Btn_Cargar5_Click(object sender, EventArgs e)
        {
            msg = "$C" + procesos[0] + "*";
            EnviarComando(msg);
        }

        private void Btn_Descargar5_Click(object sender, EventArgs e)
        {
            msg = "$D" + procesos[0] + "*";
            EnviarComando(msg);
        }

        private void PuertoList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (flag_cmd == 1)
            {

                switch (cmd)
                {
                    case "C":
                        if (cmd_num == 1)
                        {
                            Btn_Cargar1.Enabled = false;
                            Btn_Descargar1.Enabled = true;
                        }else if(cmd_num == 2)
                        {
                            Btn_Cargar2.Enabled = false;
                            Btn_Descargar2.Enabled = true;
                        }
                        else if (cmd_num == 3)
                        {
                            Btn_Cargar3.Enabled = false;
                        }
                        else if (cmd_num == 4)
                        {
                            Btn_Cargar4.Enabled = false;
                        }
                        break;
                    case "D":
                        if (cmd_num == 1)
                        {
                            Btn_Cargar1.Enabled = true;
                            Btn_Descargar1.Enabled = false;
                        }
                        else if (cmd_num == 2)
                        {
                            Btn_Cargar2.Enabled = true;
                            Btn_Descargar2.Enabled = false;
                        }
                        else if (cmd_num == 3)
                        {
                            Btn_Cargar3.Enabled = true;
                        }
                        else if (cmd_num == 4)
                        {
                            Btn_Cargar4.Enabled = true;
                        }
                        break;
                }

                flag_cmd = 0;
            }
        }

        
    }
}
