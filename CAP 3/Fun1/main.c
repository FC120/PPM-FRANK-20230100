#include <stdio.h>
#include <stdlib.h>

#define PRE_CAL 0
#define PROG 1
#define SYS_CONT 2
#define CNC 3
#define CIRCUITO2 4
#define CANT_MAT 5

//esta funcion suma dos nnumeros enteros
int suma(int a, int b);

double promedio(void);



int main()
{
    double a[4];
    int result = 0;
    int primernum = 5;
    int segundonum = 10;
    // int *ptrA;

    a[PRE_CAL]   = 100.0;
    a[PROG]      = 70.5;
    a[SYS_CONT]  = 85.0;
    a[CNC]       = 90.0;
    a[CIRCUITO2] = 60.0;

//81.1
    printf("\nPromedio es %d",suma(primernum, segundonum));
    printf("\nPromedio es %d",suma(primernum, segundonum));
    printf("\nPromedio es %d",suma(primernum, segundonum));

    /*printf("\nIngrese el primer numero: ");
    scanf("%d", &primernum);
    printf("\nIngrese el segundo numero: ");
    scanf("%d", &segundonum);

    result = suma(primernum,segundonum);
    printf("Valor de primer numero %d sumado a %d es igual a %d", primernum, segundonum,result);*/

    return 0;
}


//pasando valores
//pasar parametros por valores
int suma(int a, int b)
{
    int result;

    static int sresult;

    result = a + b;
    sresult += a+b;

    return sresult;
}



double promedio(void)
{
    double tmp = 0.0;

    for(int i = 0; i < CANT_MAT; i++)
    {

        //tmp += a[i];
    }
    //casting
    return (double)tmp / (double)CANT_MAT;
}
