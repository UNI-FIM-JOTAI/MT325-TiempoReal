/*
Tiempo real
comandos para enviar
COMANDO: $C0*     //Programa1
COMANDO: $C1*     //Programa2
COMANDO: $C2*     //Programa3
COMANDO: $C3*     //Programa4
COMANDO: $C4*     //Programa5

*/
#include <18F4550.h>

#use delay(clock=10000000)
#use rs232(baud=9600, xmit=PIN_C6,rcv=PIN_C7,bits=8,parity=N)
#fuses HS,NOPROTECT,NOWDT,NOLVP,CPUDIV1,nomclr
#define Tiempo 200

#use FAST_IO(A) 
#use FAST_IO(B)
#use FAST_IO(D)

#byte T0CON=0xFD5
#byte wreg=0xFE8
#byte TOSU=0xFFF
#byte TOSH=0xFFE
#byte TOSL=0xFFD

int np=0;
int colap[6];
int m;
int8 i,j,j1,j2,j3,j4;

int c1,c2;
int k1,k2,k3,k4,k5,k6;
int l1,l2,l3,l4,l5,l6;

char proceso;

int const lenbuff=10;
int32 valor=0;
int32 valor2=0;
int32 val1,val2,val3,val4,val5;
//int16 quantum=65048;
int16 quantum=65048;


int   xbuff=0x00;
char  cbuff[lenbuff];
char  rcvchar=0x00;
char  comando;
int1  flagcmd=0;


struct pcb{
int32 di;
int32 df; 
int32 da;
int estado; 
int wreg; 
int status;
int bsr;
int id;
} vpcb[5];

void activar_timer()
{
   set_timer0(quantum);
   enable_interrupts(INT_TIMER0);
}

void desactivar_timer()
{
   disable_interrupts(INT_TIMER0);
}

void addcbuff(char c);
void mostrar_procesos();
void descargar_proceso(int idp);
void Config_TMR0();


#INT_TIMER0
void inter_quantum()
{  int i=0;
   desactivar_timer();
   vpcb[colap[0]].wreg=wreg;
   vpcb[colap[0]].da=(int32)TOSL;
   vpcb[colap[0]].da=vpcb[colap[0]].da|((int32)TOSH<<8);
   vpcb[colap[0]].da=vpcb[colap[0]].da|((int32)TOSU<<16);
   output_toggle(PIN_D6);
   if(np>1)
   {  m=colap[0];
      for(i=0;i<np-1;i++)
      {colap[i]=colap[i+1];
      }
      colap[np-1]=m;
   }
   
   TOSL=00;
   TOSH=40;
   TOSU=00;
} 


void inte_Init()  // interrupcion de puerto serial
{
   enable_interrupts(GLOBAL);
   enable_interrupts(INT_RDA);
}


#INT_RDA
void serial_isr()
{
   //printf("Recibido");     // se envia por Serial una palabra para verificar interrupcion
   rcvchar = 0x00;
   rcvchar = getc();    // se recibe el caracter enviado por la computadora
   addcbuff(rcvchar);   // guarda el caracter en un buffer
}

void addcbuff(char c)   
{
   switch(c)
   {
      case '*':                  // en caso de recibir *, levanta el flag para saber que se termino de enviar un comando.
         cbuff[xbuff++] = c;
         flagcmd = 1;
      break;
      default:
         cbuff[xbuff++] = c;
   }
}

void inicbuff(void)           // inicializa el buffer, limpiandolo
{
   int i;
   for (i=0; i<lenbuff;i++)      
   {
      cbuff[i] = 0x00;
   }
   xbuff=0x00;
}

void procesa_cmd(void){             // procesa el ultimo comando guardado, un comando esta comprendido entre $ hasta * 
 
   int i, j=0;                      
   char salida[lenbuff];            // Argumento de comando (si lo tiene)
   disable_interrupts(int_rda);     
   flagcmd=0;                       // Desactivo flag de comando pendiente.
   for (i=0;i<xbuff;i++)
   {
      if (cbuff[i] == '$'){         // verifica que tenga '$'
         while((cbuff[i] != '*') & (i<xbuff))   // hasta que encuentre *
         {
            salida[j++]=cbuff[i++];
         }
         comando = salida[1];
         valor2 = salida[2] -'0' + 1;
         val1 = salida[2] - '0';
         val1 = val1;
         val2 = salida[3] - '0';
         val2 = val1*10 + val2;
         val3 = salida[4] - '0';
         val3 = val2*10 +val3;
         val4 = salida[5] - '0';
         val4 = val3*10+val4;
         val5 = salida[6]-'0';
         valor = val4*10 + val5;
      }
   }
   inicbuff();                            // Borro buffer.
   for(i=0;i<lenbuff;i++)                 // Bucle que pone a 0 todos los
   {
      salida[i]=0x00;                     // caracteres en el argumento
   }
   enable_interrupts(int_rda);            
}

//PROGRAMA 1: Luces Secuenciales - Bucle Infinito

#ORG 0x1000, 0x1100        // COMANDO: $C0*
void ROML_LedA1()
{
   set_tris_a(0x00);
   while(TRUE)
   {
      for (j1=0;j1<3;++j1)
      {
         IF(j1==0)
         {
            OUTPUT_BIT(PIN_A0,0);
            OUTPUT_BIT(PIN_A1,0);
         }
         IF(j1==1){OUTPUT_BIT(PIN_A0,1);}
         IF(j1==2){OUTPUT_BIT(PIN_A1,1);}
         for (k1=1;k1<200;++k1){for (l1=1;l1<200;++l1){}}
      }
   }
}

//PROGRAMA 2: Luces Secuenciales 2 - Bucle Infinito

#ORG 0x1102, 0x1200        // COMANDO: $C1*
void ROML_LedA2()
{
   set_tris_d(0x00);
   while(TRUE)
   {
      for (j2=0;j2<3;++j2)
      {
         IF(j2==0)
         {
            OUTPUT_BIT(PIN_D2,0);
            OUTPUT_BIT(PIN_D3,0);
         }
         IF(j2==1)
         {
            OUTPUT_BIT(PIN_D2,1);
         }
         IF(j2==2)
         {
            OUTPUT_BIT(PIN_D2,0);
            OUTPUT_BIT(PIN_D3,1);
         }         
         for (k2=1;k2<150;++k2){for (l2=1;l2<200;++l2){}}
      }
   }
}

//PROGRAMA 3: Luces Secuenciales C - Finito

#ORG 0x1202, 0x1300     // COMANDO: $C2*
void voidTask_LedC1(){
while(TRUE){
   while(TRUE)
   {
      for (c1=0;c1<5;c1++)
      {
         for (j3=0;j3<3;++j3)
         {
            IF(j3==0)
            {
               OUTPUT_BIT(PIN_D0,0);
               OUTPUT_BIT(PIN_D1,0);
            }
            IF(j3==1)
            {
               OUTPUT_BIT(PIN_D0,1);
            }
            IF(j3==2)
            {
               OUTPUT_BIT(PIN_D0,0);
               OUTPUT_BIT(PIN_D1,1);
            }         
            for (k5=1;k5<200;++k5){for (l5=1;l5<200;++l5){}}
         }
      }
      comando='D';
      valor2=3;
   }
}
}

//PROGRAMA 4: Luces Secuenciales C2 - Finito

#ORG 0x1302, 0x1400        // COMANDO: $C3*
void voidTask_LedC2(){
   while(TRUE){
      while(TRUE)
      {
         for (c2=0;c2<5;c2++)
         {
            for (j4=0;j4<3;++j4)
            {
               IF(j4==0)
               {
                  OUTPUT_BIT(PIN_D4,0);
                  OUTPUT_BIT(PIN_D5,0);
               }
               IF(j4==1)
               {
                  OUTPUT_BIT(PIN_D4,1);
               }
               IF(j4==2)
               {
                  OUTPUT_BIT(PIN_D4,0);
                  OUTPUT_BIT(PIN_D5,1);
               }         
               for (k6=1;k6<200;++k6){for (l6=1;l6<200;++l6){}}
            }
         }
         comando='D';
         valor2=4;
      }
   }
}

// PROGRAMA 5: Mostrar Procesos

#ORG 0x2502, 0x2850           // COMANDO: $C4*
void task_manager(){
   while(TRUE){
      desactivar_timer();
      int m;
         int32 mproceso, mdirini, mdirfin, mdiract;
         printf("|   Proceso  |  Dir.Ini  |  Dir.Fin  |  Dir.Act  |");
         for(m=0;m<np;m++)
         {
            mproceso = colap[m]+1;
            mdirini = vpcb[mproceso-1].di;
            mdirfin = vpcb[mproceso-1].df;
            mdiract = vpcb[mproceso-1].da;
            printf("|      %Lu     |   %Lu    |   %Lu    |   %Lu    |",mproceso,mdirini,mdirfin,mdiract);
         }
         printf("*");
      activar_timer();
      comando='D';
      valor2=5;
      int16 mm;
      for (mm=0;mm<250;mm++)
      {
         int mmm;
         for (mmm=0;mmm<250;mmm++)
         {
            mm=mm+1;
            mm=mm-1;
         }
      }
   }
   
}



void cargar_proceso(int idp)
{
    colap[np]=idp-1;
    vpcb[idp-1].estado=1;
    printf("Proceso %i cargado. *",idp);
    proceso=10;
    np++;
}

void descargar_proceso(int idp)
{
   int s,d,f;
   for(s=0;s<np;s++)
      {if(colap[s]==idp-1)
         {d=s;}
      }
   f=np-1;
   for(s=d;s<f;s++)
      {colap[s]=colap[s+1];
      }
   np--;   
   vpcb[idp-1].estado=0;
   proceso=0;
   printf("Proceso %i descargado. *",idp);
}

void Port_Init()
{
   set_tris_b(0x00);
   set_tris_d(0x00);
   set_tris_a(0x00);
   output_b(0x00);
   output_d(0x00);
   output_a(0x00);
}

void Config_TMR0()
{
   T0CON=0b10000111;

}

void Procesos_Init()
{
   vpcb[0].di=0x1000;
   vpcb[0].da=0x1000;   
   vpcb[0].df=0x1100;
   vpcb[1].di=0x1102;
   vpcb[1].da=0x1102;
   vpcb[1].df=0x1200;
   vpcb[2].di=0x1202;
   vpcb[2].da=0x1202;
   vpcb[2].df=0x1300;
   vpcb[3].di=0x1302;
   vpcb[3].da=0x1302;
   vpcb[3].df=0x1400;
   vpcb[4].di=0x2502;
   vpcb[4].da=0x2502;
   vpcb[4].df=0x2850;
   vpcb[0].estado=0;
   vpcb[1].estado=0;
   vpcb[2].estado=0;
   vpcb[3].estado=0;
   vpcb[4].estado=0;
   
}

void MCU_Init()
{
   printf("Conectado.............*");
   Port_Init();
   Procesos_Init();
   inte_Init();
   Config_TMR0();
   setup_spi(FALSE);
   setup_psp(PSP_DISABLED);
   setup_comparator(NC_NC_NC_NC);
   setup_vref(FALSE);
   port_b_pullups(FALSE);
}


#ORG 0x4000, 0x4FFE
void Inicio_SO()
{
   while (TRUE)
   {       
      if(flagcmd){
         procesa_cmd();
      }
      switch(comando)
      {
         case 'C':{if (valor2<6) cargar_proceso(valor2);break;}
         case 'D':{if (valor2<6) descargar_proceso(valor2);break;}
         case 'U':{for (m=1;m<6;m++) {cargar_proceso(m);}
                   break;}
         case 'X':{for (m=1;m<6;m++) {descargar_proceso(m);}
                   break;}
      }
      comando='-';
      valor2=100;
      valor=0;
       if(np>0)
       {
         if(vpcb[colap[0]].estado==1)
            {activar_timer();
             vpcb[colap[0]].estado=2;
             goto_address(vpcb[colap[0]].di);
            }
         else
            {wreg=vpcb[colap[0]].wreg;
             activar_timer();
             goto_address(vpcb[colap[0]].da);
            }
       }
   }
}

void main(void)
{
   printf("Esperando conexi�n..*");
   
   MCU_Init();
   #asm
   call 0x4000
   #endasm
}

