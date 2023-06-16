#include<stdio.h>

/* Este programa permite sumar, restar y multiplicar
    matrices cuadradas bidimensionales */


void main(void)
{
    /* Declaración de variables de la variables segun sus tipos  */
    float a11, a12, a21, a22;               /* La primera matriz */
    float b11, b12, b21, b22;               /* La segunda matriz */
    float suma11, suma12, suma21, suma22;         /* La matriz suma */
    float resta11, resta12, resta21, resta22;       /* La matriz diferencia */
    float multiplicacion11, multiplicacion12, multiplicacion21, multiplicacion22; /* La matriz multiplicacion */
    float division11, division12, division21, division22;

    /* Ingresos de datos para la memoria*/

    printf("Programa de calculo matricial");

    printf("\n\nEscriba la primera matriz por filas: ");
    scanf("%f %f %f %f", &a11, &a12, &a21, &a22);

    printf("\n\nEscriba la segunda matriz por filas: ");
    scanf("%f %f %f %f", &b11, &b12, &b21, &b22);

    /* Procesos para el calculo de las diferentes formas  */


    /*
        Suma
    */

    suma11 = a11 + b11;
    suma12 = a12 + b12;
    suma21 = a21 + b21;
    suma22 = a22 + b22;

    /*
        Resta
    */

    resta11 = a11 - b11;
    resta12 = a12 - b12;
    resta21 = a21 - b21;
    resta22 = a22 - b22;

    /*
        Multiplicacion
    */

    multiplicacion11 = a11*b11 + a12*b21;
    multiplicacion12 = a11*b12 + a12*b22;
    multiplicacion21 = a21*b11 + a22*b12;
    multiplicacion22 = a21*b21 + a22*b22;

    /*
      Divicion
    */

    division11 = a11 / b11;
    division12 = a12 / b12;
    division21 = a21 / b21;
    division22 = a22 / b22;

    /* Impresion de resultados */

    printf("\n\nLa matriz suma :\n\n");
    printf("(suma11 = %f suma12 = %f)\n(suma21 = %f suma22 = %f)",
           suma11, suma12, suma21, suma22);

    printf("\n\nLa matriz resta :\n\n");
    printf("(resta11 = %f resta12 = %f)\n(resta21 = %f resta22 = %f)",
           resta11, resta12, resta21, resta22);

    printf("\n\nLa matriz multiplicacion :\n\n");
    printf("(multiplicacion11 = %f multiplicacion12 = %f)\n(multiplicacion21 = %f multiplicacion22 = %f)",
           multiplicacion11, multiplicacion12, multiplicacion21, multiplicacion22);


    printf("\n\nLa matriz division :\n\n");
    printf("(division11 = %f division12 = %f)\n(division = %f division = %f)",
           division11,division12, division21, division22);

    printf("\n\nTerminacion normal del programa.\n");
}
