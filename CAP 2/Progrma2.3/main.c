#include <stdio.h>
/* Promedio curso.
El programa, al recibir como dato el promedio de un alumno en un curso
➥universitario, escribe aprobado si su promedio es mayor o igual a 6, o
➥reprobado en caso contrario.
PRO: variable de tipo real. */
void main(void)
{
    float PRO;
    printf ("INGRESE EL PROME: ");
        scanf ("%f", &PRO);
        if (PRO >= 6.0)
            printf ("\naprobado");
            else
            printf ("\nreprobado");
}
