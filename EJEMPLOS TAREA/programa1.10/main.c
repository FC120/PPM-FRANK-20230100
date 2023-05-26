#include <stdio.h>
#include <math.h>
/* Área del triángulo
El programa, al recibir los tres lados de un triángulo, calcula su área.
LA1, LA2, LA3, AUX y ARE: variables de tipo real. */

void main (void)
{
    float LA1, LA2, LA3, AUX, ARE;
    printf("ingrese los lados del tiangulo: " );
    scanf("%f %f %f", &LA1, &LA2, &LA3);
    AUX = (LA1 + LA2 + LA3 ) / 2;
    ARE = (AUX * (AUX - LA1) * (AUX - LA2)*(AUX - LA3)) * 0.5;
printf("\nel area del triangulo es iagual: %5.2f ", ARE );


}


