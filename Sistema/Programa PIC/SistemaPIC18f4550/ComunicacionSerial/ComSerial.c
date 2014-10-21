#include <18F4550.h>

#use delay(clock=10000000)
#use rs232(baud=9600, xmit=PIN_C6,rcv=PIN_C7,bits=8,parity=N)
#fuses HS,NOPROTECT,NOWDT,NOLVP,CPUDIV1,nomclr
#include "lcd.c"
#define Tiempo 200

#byte T0CON=0xFD5
#byte wreg=0xFE8
#byte TOSU=0xFFF
#byte TOSH=0xFFE
#byte TOSL=0xFFD

char  rcvchar=0x00;
int1  flagcmd=0;

void inte_Init()  // interrupcion de puerto serial
{
   enable_interrupts(GLOBAL);
   enable_interrupts(INT_RDA);
}

#INT_RDA
void serial_isr()
{
   printf("R1");        // se envia por Serial una palabra para verificar interrupcion
   rcvchar = getc();    // se recibe el caracter enviado por la computadora
   flagcmd = 1;         // se activa el flag que indica que se recibio un caracter
}

void main(void)
{
   inte_Init();         // se activa la interrupcion por comunicacion serial
   
   while(true){
      if(flagcmd == 1){                // se verifica si se ha recibido un nuevo caracter
         printf("com %c", rcvchar );   // se envia por Serial el caracter obtenido
         flagcmd = 0;
      }
   }
}

