#include <stdio.h>
/* Estancia
El programa, al recibir como dato la superficie de una estancia expresada
➥en acres, la convierte a hectáreas.
ECA: variable de tipo real. */

void main (void)

{
    float ECA;
printf("Ingrse la extencion de la inatancia: ");
scanf("%f", &ECA);
ECA = ECA * 4047 /10000;
printf(" \nExtensione la estancia en hectareas  %5.2f", ECA);
}
