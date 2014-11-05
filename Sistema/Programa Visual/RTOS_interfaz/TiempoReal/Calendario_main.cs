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

    public enum LogMsgType { Incoming, Outgoing, Normal, Warning, Error };

    public partial class Calendario_main : Form
    {

 #region
        // Various colors for logging info
        private Color[] LogMsgTypeColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };
        Int32[,] Matriz = new Int32[5, 4];
        int nProcesos;
        Int32[] Calendario = new Int32[9999999];
        Int32 mcm;
        private string mitrama = "";
        int[] PNC = new int[10];
        public int ver1;

 #endregion



        int c1; int c2; int c3; int c4; int c5;

        public Calendario_main()
        {
            InitializeComponent();
            
        }

        private void Calendario_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }


#region  BOTON CALENDARIZAR 

        private void Log(LogMsgType msgtype, string msg)
        {
         
            rtfTerminal.Invoke(new EventHandler(delegate
            {
                rtfTerminal.SelectedText = string.Empty;
                rtfTerminal.SelectionFont = new Font(rtfTerminal.SelectionFont, FontStyle.Bold);
                rtfTerminal.SelectionColor = LogMsgTypeColor[(int)msgtype];
                rtfTerminal.AppendText(msg);
                rtfTerminal.ScrollToCaret();
            }));
        }
       
        
        private void button1_Click(object sender, EventArgs e)
        {
            Int32 duracion;
            Int32 tmuestreo;

            nProcesos = 0;

    #region CREACION_MATRIZ_DE_PROCESOS

            if (c1 == 1)
            {
                if (textM1.Text == "")
                {
                    MessageBox.Show(this, "Error!! \n Proceso 1, Tiene que ingresar un TIEMPO DE MUESTREO", "Aviso", MessageBoxButtons.OK);
                    return;
                }
                duracion = Int32.Parse(textD1.Text);
                tmuestreo = Int32.Parse(textM1.Text);
                Matriz[nProcesos, 0] = 1;
                Matriz[nProcesos, 1] = duracion;
                Matriz[nProcesos, 2] = tmuestreo;
                Matriz[nProcesos, 3] = 1;
                nProcesos++;
                if (duracion > tmuestreo)
                {
                    MessageBox.Show(this, "Error!! \n Proceso 1, el tiempo de muestreo debe ser mayor al de duracion", "Aviso", MessageBoxButtons.OK);
                    return;
                }
            }

            if (c2 == 1)
            {
                if (textM2.Text == "")
                {
                    MessageBox.Show(this, "Error!! \n Proceso 2, Tiene que ingresar un TIEMPO DE MUESTREO", "Aviso", MessageBoxButtons.OK);
                    return;
                }
                duracion = Int32.Parse(textD2.Text);
                tmuestreo = Int32.Parse(textM2.Text);
                Matriz[nProcesos, 0] = 2;
                Matriz[nProcesos, 1] = duracion;
                Matriz[nProcesos, 2] = tmuestreo;
                Matriz[nProcesos, 3] = 2;
                nProcesos++;
                if (duracion > tmuestreo)
                {
                    MessageBox.Show(this, "Error!! \n Proceso 2, el tiempo de muestreo debe ser mayor al de duracion", "Aviso", MessageBoxButtons.OK);
                    return;
                }
            }

            if (c3 == 1)
            {
                if (textM3.Text == "")
                {
                    MessageBox.Show(this, "Error!! \n Proceso 3, Tiene que ingresar un TIEMPO DE MUESTREO", "Aviso", MessageBoxButtons.OK);
                    return;
                }
                duracion = Int32.Parse(textD3.Text);
                tmuestreo = Int32.Parse(textM3.Text);
                Matriz[nProcesos, 0] = 3;
                Matriz[nProcesos, 1] = duracion;
                Matriz[nProcesos, 2] = tmuestreo;
                Matriz[nProcesos, 3] = 3;
                nProcesos++;
                if (duracion > tmuestreo)
                {
                    MessageBox.Show(this, "Error!! \n Proceso 3, el tiempo de muestreo debe ser mayor al de duracion", "Aviso", MessageBoxButtons.OK);
                    return;
                }
            }

            if (c4 == 1)
            {
                if (textM4.Text == "")
                {
                    MessageBox.Show(this, "Error!! \n Proceso 4, Tiene que ingresar un TIEMPO DE MUESTREO", "Aviso", MessageBoxButtons.OK);
                    return;
                }
                duracion = Int32.Parse(textD4.Text);
                tmuestreo = Int32.Parse(textM4.Text);
                Matriz[nProcesos, 0] = 4;
                Matriz[nProcesos, 1] = duracion;
                Matriz[nProcesos, 2] = tmuestreo;
                Matriz[nProcesos, 3] = 4;
                nProcesos++;
                if (duracion > tmuestreo)
                {
                    MessageBox.Show(this, "Error!! \n Proceso 4, el tiempo de muestreo debe ser mayor al de duracion", "Aviso", MessageBoxButtons.OK);
                    return;
                }
            }

            if (c5 == 1)
            {
                if (textM5.Text == "")
                {
                    MessageBox.Show(this, "Error!! \n Proceso 5, Tiene que ingresar un TIEMPO DE MUESTREO", "Aviso", MessageBoxButtons.OK);
                    return;
                }
                duracion = Int32.Parse(textD5.Text);
                tmuestreo = Int32.Parse(textM5.Text);
                Matriz[nProcesos, 0] = 5;
                Matriz[nProcesos, 1] = duracion;
                Matriz[nProcesos, 2] = tmuestreo;
                Matriz[nProcesos, 3] = 5;
                nProcesos++;
                if (duracion > tmuestreo)
                {
                    MessageBox.Show(this, "Error!! \n Proceso 5, el tiempo de muestreo debe ser mayor al de duracion", "Aviso", MessageBoxButtons.OK);
                    return;
                }
            }

    #endregion 

    #region MUESTRA_LA_MATRIZ_DE_PROCESOS

            int auxiliar;
            //Mostar tabla de procesos
            Log(LogMsgType.Normal, String.Format("\nTabla de procesos:\n"));
            Log(LogMsgType.Normal, String.Format("\n  Dir-Te-Tm\n"));
            for (int i = 0; i < nProcesos; i++)
            {
                Log(LogMsgType.Normal, String.Format("P"));
                Log(LogMsgType.Normal, String.Format(Matriz[i, 3].ToString()));
                Log(LogMsgType.Normal, String.Format(" "));
                for (int j = 0; j < 3; j++)
                {
                    Log(LogMsgType.Normal, String.Format(Matriz[i, j].ToString()));
                    Log(LogMsgType.Normal, String.Format("  "));
                }
                Log(LogMsgType.Normal, String.Format("\n"));

            }
            // fin de mostrar tabla
    #endregion

    #region ORDENAMIENTO DE LA MATRIZ DE PROCESOS
     
            //Ordenar en forma descendente respecto al tiempo de muestreo
            for (int i = 0; i < nProcesos; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Matriz[j, 2] < Matriz[i, 2])
                    {
                        auxiliar = Matriz[j, 0];
                        Matriz[j, 0] = Matriz[i, 0];
                        Matriz[i, 0] = auxiliar;

                        auxiliar = Matriz[j, 1];
                        Matriz[j, 1] = Matriz[i, 1];
                        Matriz[i, 1] = auxiliar;

                        auxiliar = Matriz[j, 2];
                        Matriz[j, 2] = Matriz[i, 2];
                        Matriz[i, 2] = auxiliar;

                        auxiliar = Matriz[j, 3];
                        Matriz[j, 3] = Matriz[i, 3];
                        Matriz[i, 3] = auxiliar;
                    }
                }
            }
            // Fin de ordenamiento
    #endregion

    #region ALGORITMO PARA CALCULAR EL 'MCM'
            // Algortimo para calcular el mcm.
            mcm = 1;
            Int32[] N = new Int32[5];
            for (int i = 0; i < nProcesos; i++)
                N[i] = Matriz[i, 2];
            for (int i = nProcesos; i < 5; i++)
                N[i] = 1;

            Int32 cont = 2;
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
            // Fin del algoritmo para calcular MCM
    #endregion 

    #region MUESTRA LA MATRIZ ORDENADA 

            Log(LogMsgType.Normal, String.Format("\nTabla de procesos ordenado:\n"));
            Log(LogMsgType.Normal, String.Format("\n  Dir-Te-Tm\n"));
            for (int i = 0; i < nProcesos; i++)
            {
                Log(LogMsgType.Normal, String.Format("P"));
                Log(LogMsgType.Normal, String.Format(Matriz[i, 3].ToString()));
                Log(LogMsgType.Normal, String.Format(" "));
                for (int j = 0; j < 3; j++)
                {
                    Log(LogMsgType.Normal, String.Format(Matriz[i, j].ToString()));
                    Log(LogMsgType.Normal, String.Format("  "));
                }
                Log(LogMsgType.Normal, String.Format("\n"));

            }

            Log(LogMsgType.Normal, String.Format("\n\nMCM: "));
            Log(LogMsgType.Normal, String.Format(mcm.ToString()));

    #endregion 

    #region CONDICION DE TAMAÑO PARA LA MEMORIA DEL PIC
            // tamaño del vector si es mayor que 1400 no entra en la memoria del pic 
            if (mcm >= 40020)       //    mcm >= 1400)
            {
                Log(LogMsgType.Normal, String.Format("\n\n....Imposible calendarizar, espacio insuficiente en el PIC !!!!! "));
                return;
            }
            //========================
    #endregion

    #region CREACION DEL VECTOR CALENDARIZADO 
 
   // iniciamos en cero todo el calendario
            for (int i = 0; i < mcm; i++)
             Calendario[i] = 0;
  // fin de inicializacion en cero

  // CALENDARIZAION   
            /*
            Int32 actual = 0;
            Int32 anterior = 0;
            Int32 inicio;
            Int32 mult = 1;
            int bandera;
            
            
            for (int i = 0; i < nProcesos; i++)   // Entra a todos los procesos
            {
                if (i == 0)
                    inicio = 0;
                else
                    inicio = Matriz[i - 1, 1] + anterior;    // Duracion + anterior 

                anterior = inicio;
                mult = 0;
                actual = inicio + Matriz[i, 2] * mult;
                while (actual < mcm)
                {
                    bandera = 0;
                    actual = inicio + Matriz[i, 2] * mult;
                    mult++;
                    for (int j = 0; j < Matriz[i, 1]; j++)
                    {
                        if (Calendario[actual + j] != 0)
                            bandera = 1;
                    }
                    if (bandera == 0)
                    {
                        for (int j = 0; j < Matriz[i, 1]; j++)
                        {
                            Calendario[actual + j] = Matriz[i, 0];
                        }
                    }

                }

            }

            */

            
            Int32 cont1 = 0;
            int cont_2 = 0;
            Int32 Tm1=0;
            Int32 inicio = 0;
            // Int32 mult = 0;
            int flag1=0;
          
         
            //inicio = 0;
            //mult = 0;

            for (int i = 0; i < 10; i++)
                PNC[i] = 0;


            for (int i = 0; i < nProcesos; i++)   // Entra a todos los procesos
            {
                cont1 = mcm / Matriz[i, 2];
                Tm1 = Matriz[i, 2];

                for (int j = 0; j < cont1; j++)
                {
                    for (int k = 0; k < Matriz[i, 1]; k++)
                    {

                        if (Calendario[inicio + j * Tm1 + k] == 0)
                        {
                            Calendario[inicio + j * Tm1 + k] = Matriz[i, 0];
                        }
                        else
                        {
                            Calendario[inicio + j * Tm1 + k] = Matriz[i, 0];

                            flag1 = 1;
                            PNC[cont_2] = Matriz[i,0];
                            cont_2++;
                        }
                    }
                }
                inicio = inicio + Matriz[i, 1]; // incrementa la duracion del proceso anterior 
             }
            int tamaño = 0;


            for (int s1 = 0; s1 < 10; s1++)
            {
                if (PNC[s1] != 0)
                {
                    tamaño++;
                }
            }
            
            textBox1.AppendText(tamaño.ToString());



            if (flag1 == 1)
            {   

                MessageBox.Show("El proceso  " + ver1.ToString() + "  no se puede calendarizar ");
    
            }
            flag1 = 0;
            ver1 = 0;
            cont_2 = 0;
            tamaño = 0;
           
          



    #endregion 

    #region MUESTRA EL VECTOR CALENDARIO
            Log(LogMsgType.Normal, String.Format("\n\nCalendario completo sin modificar: \n"));
            //mostrar el caelndario completo
            for (int i = 0; i < mcm; i++)
            {
                switch (Calendario[i])
                {
                    case 1:
                        Log(LogMsgType.Normal, String.Format("P1 "));
                        break;
                    case 2:
                        Log(LogMsgType.Normal, String.Format("P2 "));
                        break;
                    case 3:
                        Log(LogMsgType.Normal, String.Format("P3 "));
                        break;
                    case 4:
                        Log(LogMsgType.Normal, String.Format("P4 "));
                        break;
                    case 5:
                        Log(LogMsgType.Normal, String.Format("P5 "));
                        break;
                    default:
                        Log(LogMsgType.Normal, String.Format("00 "));
                        break;
                }
            }
            //Fin de mostrar el calendario
            #endregion

    #region VECTOR MODIFICADO 
            int temp; 

            temp = Calendario[0];
            for (int i = 1; i < mcm ; i++)
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




    #endregion

    #region MUESTRA EL CALENDARIO EN LA PANTALLA
            Log(LogMsgType.Normal, String.Format("\n\nCalendario completo: \n"));
            //mostrar el caelndario completo
            for (int i = 0; i < mcm; i++)
            {
                switch (Calendario[i])
                {
                    case 1:
                        Log(LogMsgType.Normal, String.Format("P1 "));
                        break;
                    case 2:
                        Log(LogMsgType.Normal, String.Format("P2 "));
                        break;
                    case 3:
                        Log(LogMsgType.Normal, String.Format("P3 "));
                        break;
                    case 4:
                        Log(LogMsgType.Normal, String.Format("P4 "));
                        break;
                    case 5:
                        Log(LogMsgType.Normal, String.Format("P5 "));
                        break;
                    default:
                        Log(LogMsgType.Normal, String.Format("00 "));
                        break;
                }
            }
            //Fin de mostrar el calendario
      #endregion

    #region MUESTRA PROCESOS QUE NUNCA SE CALENDARIZAN DEBIDO AL TAMAÑO

            int bandera_cal = 0;
            for (int i = 0; i < nProcesos; i++)
            {
                bandera_cal = 0;
                for (int j = 0; j < mcm; j++)
                {
                    if (Matriz[i, 3] == Calendario[j])
                    {
                        bandera_cal = 1;
                        break;
                    }

                }
                if (bandera_cal == 0)
                {
                    Log(LogMsgType.Normal, String.Format("\n\n....Imposible calendarizar, El proceso "));
                    Log(LogMsgType.Normal, String.Format(Matriz[i, 3].ToString()));
                    Log(LogMsgType.Normal, String.Format(" NUNCA SE EJECUTA...!!! "));
                    Log(LogMsgType.Normal, String.Format("\n EL TIEMPO DE MUESTREMO DE MAYOR DURACION TIENE QUE SER MAYOR O IGUAL A LA SUMA DE LOS TIEMPOS DE DURACION...!!! "));
                }
            }

   #endregion 

        }
#endregion

        
        
//==========================================================================================================================
        private void button4_Click(object sender, EventArgs e)
        {
            string procesoc;
            procesoc = procesoN.Text;
            switch (procesoc)
            {
                case "1":
                    if (c1 == 0)
                    {   
                        textD1.Enabled = true;
                        textM1.Enabled = true;
                        c1 = 1;
                        break;
                    }
                    else
                    { MessageBox.Show(this, "Proceso 1: \n Ya ha sido elegido", "Aviso", MessageBoxButtons.OK); break; }
                
                case "2":
                    if (c2 == 0)
                    {
                        // textD2.Text = "3";
                        textD2.Enabled = true;
                        textM2.Enabled = true;
                        c2 = 1;
                        break;
                    }
                    else
                    { MessageBox.Show(this, "Proceso 2: \n Ya ha sido elegido", "Aviso", MessageBoxButtons.OK); break; }

                
                case "3":
                    if (c3 == 0)
                    {
                        //textD3.Text = "4";
                        textD3.Enabled = true;
                        textM3.Enabled = true;
                        c3 = 1;
                        break;
                    }
                    else
                    { MessageBox.Show(this, "Proceso 3: \n Ya ha sido elegido", "Aviso", MessageBoxButtons.OK); break; }
                
                case "4":
                    if (c4 == 0)
                    {
                        //textD4.Text = "5";
                        textD4.Enabled = true;
                        textM4.Enabled = true;
                        c4 = 1;
                        break;
                    }
                    else
                    { MessageBox.Show(this, "Proceso 4: \n Ya ha sido elegido", "Aviso", MessageBoxButtons.OK); break; }
                
                case "5":
                    if (c5 == 0)
                    {
                        // textD5.Text = "6";
                        textD5.Enabled = true;
                        textM5.Enabled = true;
                        c5 = 1;
                        break;
                    }
                    else
                    { MessageBox.Show(this, "Proceso 5: \n Ya ha sido elegido", "Aviso", MessageBoxButtons.OK); break; }
                
                default:
                    MessageBox.Show(this, "Error! \nLos procesos son: 1, 2, 3, 4 ó 5.", "Proceso invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            string procesoc;
            procesoc = procesoN.Text;
            switch (procesoc)
            {
                case "1":
                    if (c1 == 1)
                    {
                        textD1.Text = ""; textM1.Text = "";
                        textD1.Enabled = false; textM1.Enabled = false; c1 = 0;
                        break;
                    }
                    else
                    { MessageBox.Show(this, "Proceso 1: \n No esta activado", "Aviso", MessageBoxButtons.OK); break; }
                case "2":
                    if (c2 == 1)
                    {
                        textD2.Text = ""; textM2.Text = "";
                        textD2.Enabled = false; textM2.Enabled = false; c2 = 0;
                        break;
                    }
                    else
                    { MessageBox.Show(this, "Proceso 2: \n No esta activado", "Aviso", MessageBoxButtons.OK); break; }

                case "3":
                    if (c3 == 1)
                    {
                        textD3.Text = ""; textM3.Text = "";
                        textD3.Enabled = false; textM3.Enabled = false; c3 = 0;
                        break;
                    }
                    else
                    { MessageBox.Show(this, "Proceso 3: \n No esta activado", "Aviso", MessageBoxButtons.OK); break; }
                case "4":
                    if (c4 == 1)
                    {
                        textD4.Text = ""; textM4.Text = "";
                        textD4.Enabled = false; textM4.Enabled = false; c4 = 0;
                        break;
                    }
                    else
                    { MessageBox.Show(this, "Proceso 4: \n No esta activado", "Aviso", MessageBoxButtons.OK); break; }
                case "5":
                    if (c5 == 1)
                    {
                        textD5.Text = ""; textM5.Text = "";
                        textD5.Enabled = false; textM5.Enabled = false; c5 = 0;
                        break;
                    }
                    else
                    { MessageBox.Show(this, "Proceso 5: \n No esta activado", "Aviso", MessageBoxButtons.OK); break; }
                default:
                    MessageBox.Show(this, "Error! \nLos procesos son: 1, 2, 3, 4 ó 5.", "Proceso invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.rtfTerminal.Text = " 'AYUDA' \rEl valor del Quantum esta definido por lo tanto solo se tiene que ingresar el numero de quantums en las cajas de textos ya establecidos ('DURACION' y 'TIEMPO DE MUESTREO') ";
          




        }

        private void button2_Click(object sender, EventArgs e)
        {
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            mitrama = "";
            mitrama += "6W"; // enviamos el comando 4 que es para ver procesos, el D incica el fin de la trama
            //serialPort1.Write(mitrama);
            mitrama = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mitrama = "";
            mitrama += "9W"; // enviamos el comando 4 que es para ver procesos, el D incica el fin de la trama
            //serialPort1.Write(mitrama);
            mitrama = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mitrama = "";
            mitrama += "5W"; // enviamos el comando 4 que es para ver procesos, el D incica el fin de la trama
            //serialPort1.Write(mitrama);
            mitrama = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mitrama = "";
            mitrama += "7W"; // enviamos el comando 4 que es para ver procesos, el D incica el fin de la trama
            //serialPort1.Write(mitrama);
            mitrama = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mitrama = "";
            mitrama += "8W"; // enviamos el comando 4 que es para ver procesos, el D incica el fin de la trama
            //serialPort1.Write(mitrama);
            mitrama = "";
        }

        private void procesoN_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
