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
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox_Ayuda.Text = "Comandos: \n1.-Cargar Proceso: Ejecuta el proceso al ingresar y enviar\n   la direccion y el nombre.\n2.-Descargar Proceso: Detiene la ejecucion del proceseso\n   al ingresar el ID y presionar el boton Desgcargar.\n3.-Administrador de Procesos: Con esta opcion puedes ver todos los\n   procesos que se estan ejecutando  en timepo real con todas sus\n   propiedades con solo presionar el boton ver administrador.\n"+
                "3.-Ayuda: Con esta opcion puedes obtener informacion con respecto\n   al S.O. y sus comandos basicos.\n4.-Version del SO: version del sistema operativo en tiempo real.\n5.-Historial: Se puede ver todos los comandos anteriormente\n   ejecutados.\n \rNombres y direcciones de los Procesos: \n"+
                " Nombre:    Direccion:" + "\n" + "  LED1       0x004096:  PROCESO 1" + "\n" + "  LED2       0x004192:  PROCESO 2" + "\n" + "  LED3       0x004384:  PROCESO 3" + "\n" + "  ADC1       0x004096:  Señal Analogica";
          
         }
    }
}
