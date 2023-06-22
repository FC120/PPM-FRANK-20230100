#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a = 100;
    int b = 500;
    int c = 0;
    int as[1000];
    int *ptrA;
    int n;
    a = sizeof(as);
    b = sizeof(*as);
    n = sizeof(as) / sizeof(*as);

    printf("\nCantidad de numeros en AS: n= %d", n);
    printf("\nValor tamano en byte de AS: a= %d", a);
    printf("\nTamano del dato en AS: b= %d", b);
    printf("\nTamano de un entero: %d", sizeof(long long));

  /*  ptrA = &b;

    *ptrA = 5;


*/


    //printf("\nValor direccion en ptrA: %p", &ptrA);

    return 0;
}
