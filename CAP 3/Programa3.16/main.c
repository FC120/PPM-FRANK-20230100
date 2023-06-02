#include <stdio.h>
#include <stdlib.h>

/* Calificaciones.
El programa, al recibir un grupo de calificaciones de un alumno, obtiene el promedio de calificaciones de cada uno de ellos y, además, los alumnos con el mejor
y peor promedio.
I, MAT, MAMAT y MEMAT: variables de tipo entero.
CAL, SUM, MAPRO, MEPRO y PRO: variables de tipo real.*/

void main(void)
{
    int I, MAT, MAMAT, MEMAT;
    float CAL, SUM, MAPRO = 0, MEPRO = 11, PRO;
    printf("Ingrese la matricula del primer alumno:\t");
    scanf("%d", &MAT);

    while (MAT)
    {
        SUM = 0;
        for ( I = 1; I <= 5; I++)
        {
            printf("\tIngrese la calificacion del alumno: ", I);
            scanf("%d", &MAT);
            SUM += CAL;
        }
        PRO = SUM / 5;
        printf("\nMatricula:%d\tPromedio:%5.2f", MAT, PRO);

        if(PRO > MAPRO)
        {
            MAPRO = PRO;
            MAMAT = MAT;
        }
        if(PRO < MEPRO)
        {
            MEPRO = PRO;
            MEMAT = MAT;
        }
        printf("\n\nIngrese la matrícula del siguiente alumno: ");
        scanf("%d", &MAT);

    }
    printf("\n\nAlumno con mejor Promedio:\t%d\t\%5.2f", MAMAT, MAPRO);
    printf("\n\nAlumno con peor Promedio:\t%d\t\%5.2f", MEMAT, MEPRO);


    return 0;
}
