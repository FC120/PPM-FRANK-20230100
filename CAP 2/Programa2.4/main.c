#include <stdio.h>
/* incremento de precio.
El programa, al recibir como dato el precio de un producto, incrementa al
➥mismo 11% si es menor a 1500$ y 8% en caso contrario (mayor o igual).
PRE y NPR: variables de tipo real. */
void main(void){
float PRE,NPR;
printf("INGRESE EL PRECIO DEL PRODUCTO: ");
scanf("%f", &PRE);
if ( PRE <= 1500)
NPR = PRE * 1.11;

else ( PRE >= 1500);
NPR = PRE * 1.08;
    printf("\nEL NUEVO PRECIO ES: %8.2f", NPR);


}
