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
    public partial class Caledarizacion : Form
    {
        #region DECLARACION DE VARIABLES
        int [] Calendario = new int[20000];
        int [] CalendarioPIC = new int[20000];
        int tam_calendario;
        int [,] Procesos = new int[5,4];
        int NumProcesos = 0;
        int Proceso, Duracion, Periodo;
        int tmpProceso, tmpDuracion, tmpPeriodo; 
        int [] DuracionProceso = {4,4,2,2,3};
        int [] PeriodoMuestreo = {20,20,10,20,10};
        int[] ListaProcesos = {4,5,0,7,8};
        int MCM;
        string TxMCM;
        private string data = "";
        private int j = 0;
        private string cmd="";
        int cmd_num=0;
        int flag_cmd=0;
        int estado_conexion = 0;
        int valor = 0;

        int flag_envio=0;
        int pos_envio, proceso_envio;
        string Txtmp;
        string msg;
        

        #endregion

        public Caledarizacion()
        {
            InitializeComponent();
            PuertoList.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                PuertoList.Items.Add(s);
                PuertoList.Text = s;
            }
            PuertoSerial.PortName = "COM1";

            BtnCargar.Enabled = false;
            BtnEjecutar.Enabled = false;
            BtnDetener.Enabled = false;
            BtnLecturaADC.Enabled = true;
        }

        private void Caledarizacion_Load(object sender, EventArgs e)
        {
            Deshabilitar_TxBx_Duraciones();
            Deshabilitar_TxBx_Periodos();
            DefinirDuracionPedeterminada();
            DefinirPeriodoPredeterminado();
            NumProcesos = 0;
            Timer.Enabled = true;
            RTBx_Terminal.Text = "INICIO";
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
                    BtnCargar.Enabled = true;
                    BtnEjecutar.Enabled = true;
                    BtnDetener.Enabled = true;
                    BtnLecturaADC.Enabled = false;
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
                    BtnCargar.Enabled = false;
                    BtnEjecutar.Enabled = false;
                    BtnDetener.Enabled = false;
                    BtnLecturaADC.Enabled = true;
                }
            }

            
        }

        private void PuertoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PuertoSerial.PortName = PuertoList.Text;
        }

        private void ChBx_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalendarizar_Click(object sender, EventArgs e)
        {
            NumProcesos = 0;
            RTBx_Terminal.Text = "Iniciando Calendarizacion\nProcesos Selecionados\n";
            Actualizar_CheckButton();
            OrdenandoMatrizProcesos();
            MCM = MCMMatrizProcesos();
            this.RTBx_Terminal.AppendText("El MCM es: " + MCM + "\n");
            this.RTBx_Terminal.AppendText("\nCreando el Calendario \n");
            CrearCalendario();
            MostrarCalendario();
            this.RTBx_Terminal.AppendText("\n\nPreparando Calendario Para el PIC \n");
            CrearCalendarioPIC();
            MostrarCalendario();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            msg = "$M0";
            TxMCM = Convert.ToString(MCM);
            while (TxMCM.Length < 3)
            {
                TxMCM = "0" + TxMCM;
            }
            msg = msg + TxMCM;
            msg = msg + "*";
            this.RTBx_Terminal.AppendText("\nCargando Calendario ...\nPor favor espere.\n");
            EnviarComando(msg);
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            msg = "$T0*";
            this.RTBx_Terminal.AppendText("Ejecutando Calendario\n");
            EnviarComando(msg);
            BtnConexion.Enabled = false;
        }

        private void BtnDetener_Click(object sender, EventArgs e)
        {
            msg = "$R0*";
            this.RTBx_Terminal.AppendText("Deteniendo Calendario\n");
            EnviarComando(msg);
            BtnConexion.Enabled = true;
        }

        private void Actualizar_CheckButton() 
        {
            
            
            if (ChBx_1.Checked) {
                Proceso = ListaProcesos[0];
                if (TxBx_D1.Text != "" && TxBx_T1.Text != "")
                {
                    Duracion = Int32.Parse(TxBx_D1.Text);
                    Periodo = Int32.Parse(TxBx_T1.Text);
                    AddProceso(Proceso);
                    NumProcesos++;
                }
                else
                {
                    ErrorCasilleroVacioProceso(Proceso);
                }

            }
            if (ChBx_2.Checked)
            {
                Proceso = ListaProcesos[1];
                if (TxBx_D2.Text != "" && TxBx_T2.Text != "")
                {
                    Duracion = Int32.Parse(TxBx_D2.Text);
                    Periodo = Int32.Parse(TxBx_T2.Text);
                    AddProceso(Proceso);
                    NumProcesos++;
                }
                else
                {
                    ErrorCasilleroVacioProceso(Proceso);
                }
            }
            if (ChBx_3.Checked)
            {
                Proceso = ListaProcesos[2];
                if (TxBx_D3.Text != "" && TxBx_T3.Text != "")
                {
                    Duracion = Int32.Parse(TxBx_D3.Text);
                    Periodo = Int32.Parse(TxBx_T3.Text);
                    AddProceso(Proceso);
                    NumProcesos++;
                }
                else
                {
                    ErrorCasilleroVacioProceso(Proceso);
                }
            }
            if (ChBx_4.Checked)
            {
                Proceso = ListaProcesos[3];
                if (TxBx_D4.Text != "" && TxBx_T4.Text != "")
                {
                    Duracion = Int32.Parse(TxBx_D4.Text);
                    Periodo = Int32.Parse(TxBx_T4.Text);
                    AddProceso(Proceso);
                    NumProcesos++;
                }
                else
                {
                    ErrorCasilleroVacioProceso(Proceso);
                }
            }
            if (ChBx_5.Checked)
            {
                Proceso = ListaProcesos[4];
                if (TxBx_D5.Text != "" && TxBx_T5.Text != "")
                {
                    Duracion = Int32.Parse(TxBx_D5.Text);
                    Periodo = Int32.Parse(TxBx_T5.Text);
                    AddProceso(Proceso);
                    NumProcesos++;
                }
                else
                {
                    ErrorCasilleroVacioProceso(Proceso);
                }
            }
        }

        private void ChBx_Duracion_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBx_Duracion.Checked)
            {
                Habilitar_TxBx_Duraciones();
            }
            else
            {
                Deshabilitar_TxBx_Duraciones();
            }
        }

        private void ChBx_PeriodoMuestreo_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBx_PeriodoMuestreo.Checked)
            {
                Habilitar_TxBx_Periodos();
            }
            else
            {
                Deshabilitar_TxBx_Periodos();
            }
        }

        private void BtnPredeterminado_Click(object sender, EventArgs e)
        {
            if (!ChBx_Duracion.Checked)
            {
                DefinirDuracionPedeterminada();
            }
            if (!ChBx_PeriodoMuestreo.Checked)
            {
                DefinirPeriodoPredeterminado();
            }
        }

        private void AddProceso(Int32 Proceso)
        {
            this.RTBx_Terminal.AppendText("Seleccionado Proceso " + Proceso + "\n");
            Procesos[NumProcesos, 0] = Proceso;
            Procesos[NumProcesos, 1] = Duracion;
            Procesos[NumProcesos, 2] = Periodo;
            Procesos[NumProcesos, 3] = 1;
        }

        #region FUNCIONES PARA CALENDARIZACION

        private void OrdenandoMatrizProcesos()
        {   // Ordenando por el Periodo de muestreo
            for (int i=0; i < NumProcesos; i++)
            {
                for (int j = i+1; j < NumProcesos; j++)
                {
                    if (Procesos[i, 2] < Procesos[j, 2])
                    {
                        tmpProceso = Procesos[i, 0];
                        tmpDuracion = Procesos[i, 1];
                        tmpPeriodo = Procesos[i, 2];
                        Procesos[i, 0] = Procesos[j, 0];
                        Procesos[i, 1] = Procesos[j, 1];
                        Procesos[i, 2] = Procesos[j, 2];
                        Procesos[j, 0] = tmpProceso;
                        Procesos[j, 1] = tmpDuracion;
                        Procesos[j, 2] = tmpPeriodo;
                    }
                }
            }
        }

        private int MCMMatrizProcesos()
        {   
            int[] N = new int[5];
            int mcm = 1;
            int cont=2;

            for (int i = 0; i < NumProcesos; i++)
            {
                N[i] = Procesos[i, 2];
            }

            for (int i = NumProcesos; i < 5; i++)
            {
                N[i] = 1;
            }
            while (N[0] != 1 || N[1] != 1 || N[2] != 1 || N[3] != 1 || N[4] != 1)
            {
                while (N[0] % cont == 0 || N[1] % cont == 0 || N[2] % cont == 0 || N[3] % cont == 0 || N[4] % cont == 0)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (N[i] % cont == 0)
                            N[i] = N[i] / cont;
                    }
                    mcm = mcm * cont;
                }
                cont++;
            }
            return mcm;
        }

        private void CrearCalendario()
        {
            int rep;
            int tam,per;
            int inicio = 0;
            int pos=0,ultm_pos=0;
            tam_calendario = 0;

            for (int i = 0; i < MCM; i++)
            {
                Calendario[i] = 0;
            }

            for (int i = 0; i < NumProcesos; i++)
            {
                rep = MCM / Procesos[i, 2];
                per = Procesos[i, 2];
                tam = Procesos[i, 1];
                for (int j = 0; j < rep; j++)
                {
                    for (int k = 0; k < tam; k++)
                    {
                        pos = inicio + j*per+k;
                        if (pos > ultm_pos)
                        {
                            ultm_pos = pos;
                        }

                        if (Calendario[pos] == 0)
                        {
                            Calendario[pos] = Procesos[i, 0];
                        }
                        else
                        {
                            Procesos[i, 3] = 0;
                        }
                    }
                }

                if (Procesos[i, 3] == 0)
                {
                    ErrorProcesoNoCalendarizable(Procesos[i, 0]);
                    QuitarProcesoCalendario(ultm_pos, Procesos[i, 0]);
                }
                else
                {
                    inicio = inicio + tam;
                }
            }
            tam_calendario = ultm_pos+1;
        }

        private void CrearCalendarioPIC()
        {
            int temp;

            temp = Calendario[0];
            for (int i = 1; i < MCM; i++)
            {
                if (temp == Calendario[i])
                {
                    Calendario[i] = 0;
                }
                else
                {
                    temp = Calendario[i];
                }
            }
        }

        private void MostrarCalendario()
        {
            for (int i = 0; i < MCM; i++)
            {
                if (Calendario[i] != 0)
                {
                    this.RTBx_Terminal.AppendText("P" + Calendario[i] + " ");
                }
                else
                {
                    this.RTBx_Terminal.AppendText("00 ");
                }
            }
        }

        private void QuitarProcesoCalendario(int ultm_pos, int Proceso)
        {
            for (int i = 0; i <= ultm_pos; i++)
            {
                if (Calendario[i] == Proceso)
                {
                    Calendario[i] = 0;
                }
            }
        }

        #endregion

        #region HABILITAR Y DESHABILITAR
        private void Deshabilitar_TxBx_Duraciones()
        {
            TxBx_D1.Enabled = false;
            TxBx_D2.Enabled = false;
            TxBx_D3.Enabled = false;
            TxBx_D4.Enabled = false;
            TxBx_D5.Enabled = false;
        }

        private void Habilitar_TxBx_Duraciones()
        {
            TxBx_D1.Enabled = true;
            TxBx_D2.Enabled = true;
            TxBx_D3.Enabled = true;
            TxBx_D4.Enabled = true;
            TxBx_D5.Enabled = true;
        }

        private void Deshabilitar_TxBx_Periodos()
        {
            TxBx_T1.Enabled = false;
            TxBx_T2.Enabled = false;
            TxBx_T3.Enabled = false;
            TxBx_T4.Enabled = false;
            TxBx_T5.Enabled = false;
        }

        private void Habilitar_TxBx_Periodos()
        {
            TxBx_T1.Enabled = true;
            TxBx_T2.Enabled = true;
            TxBx_T3.Enabled = true;
            TxBx_T4.Enabled = true;
            TxBx_T5.Enabled = true;
        }
        #endregion

        #region VALORES PREDETERMINADOS
        private void DefinirDuracionPedeterminada()
        {
            TxBx_D1.Text = Convert.ToString(DuracionProceso[0]);
            TxBx_D2.Text = Convert.ToString(DuracionProceso[1]);
            TxBx_D3.Text = Convert.ToString(DuracionProceso[2]);
            TxBx_D4.Text = Convert.ToString(DuracionProceso[3]);
            TxBx_D5.Text = Convert.ToString(DuracionProceso[4]);
        }
        private void DefinirPeriodoPredeterminado()
        {
            TxBx_T1.Text = Convert.ToString(PeriodoMuestreo[0]);
            TxBx_T2.Text = Convert.ToString(PeriodoMuestreo[1]);
            TxBx_T3.Text = Convert.ToString(PeriodoMuestreo[2]);
            TxBx_T4.Text = Convert.ToString(PeriodoMuestreo[3]);
            TxBx_T5.Text = Convert.ToString(PeriodoMuestreo[4]);
        }
        #endregion

        #region MENSAJES DE ERROR

        private void ErrorCasilleroVacioProceso(int Proceso)
        {
            MessageBox.Show(this, "Error 101 / Casillero Vacio del Proceso " + Proceso + "\n No se calendarizara el Proceso", "AVISO", MessageBoxButtons.OK);
        }

        private void ErrorProcesoNoCalendarizable(int Proceso)
        {
            MessageBox.Show(this, "Error 102 / El proceso" + Proceso + " no puede calendarizarse\n No se calendarizara el Proceso", "AVISO", MessageBoxButtons.OK);
        }
        #endregion

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            RTBx_Terminal.Text = "";
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
            this.RTBx_Terminal.AppendText("<- " + data + "\n");
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
            //this.RTBx_Terminal.AppendText("\nComando:"+cmd);
            //this.RTBx_Terminal.AppendText("\nNumero:"+Convert.ToString(cmd_num)+"\n");
            data = "";
            flag_cmd = 1;

        }

        private void EnviarComando(string Enviardato)
        {
            this.RTBx_Terminal.AppendText("-> ");
            int tam_s=0;
            string temp_char;
            tam_s = Enviardato.Length;
            if (tam_s != 0)
            {
                for (int i = 1; i < tam_s; i++)
                {
                    temp_char = Enviardato.Remove(i);
                    temp_char = temp_char.Remove(0, i - 1);
                    PuertoSerial.Write(temp_char);
                    this.RTBx_Terminal.AppendText(temp_char);
                    Thread.Sleep(50);

                }
                temp_char = Enviardato.Remove(0, tam_s - 1);
                this.RTBx_Terminal.AppendText(temp_char);
                PuertoSerial.Write(temp_char);
                this.RTBx_Terminal.AppendText("\n");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (flag_cmd == 1) {

                switch (cmd)
                {
                    case "M":
                        if (cmd_num == 0)
                        {
                            flag_envio = 1;
                            pos_envio = 0;
                            proceso_envio = 0;
                        }
                        if (cmd_num == 1) 
                        { 
                            flag_envio = 0;
                            this.RTBx_Terminal.AppendText("Calendario Cargado\n");
                        }
                        break;
                    case "P":
                        if (cmd_num != proceso_envio)
                        {
                            // aun no se hace nada
                        }
                        break;
                }

                if (flag_envio == 1 )
                {

                    if (pos_envio >= MCM)
                    {
                        msg = "$M1*";
                        EnviarComando(msg);
                    }
                    else
                    {
                        msg = "";
                        msg = msg + "$P";
                        proceso_envio = Calendario[pos_envio];
                        msg = msg + Convert.ToString(proceso_envio);
                        Txtmp = Convert.ToString(pos_envio);
                        while (Txtmp.Length < 3)
                        {
                            Txtmp = "0" + Txtmp;
                        }
                        this.RTBx_Terminal.AppendText("\nposicion:" + Txtmp);
                        msg = msg + Txtmp;
                        msg = msg + "*";
                        EnviarComando(msg);
                    }
                    do
                    {
                        pos_envio++;
                    } while (Calendario[pos_envio] == 0 && pos_envio <= MCM) ;
                    
                }

                flag_cmd = 0;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnLecturaADC_Click(object sender, EventArgs e)
        {
            LecturaADC frm1 = new LecturaADC();
            frm1.Show();
        }
 
    }
}
