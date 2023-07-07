#include <stdio.h>
#define PRECIO_GALON 274.50
#define litro 3.785

    int main() {
    char nombre[50];
    float kilometros, litros,rendimiento;
    float pago_de_seguro,seguro_por_kilometros;
    float mantenimineto,precio_de_manteniminto_por_kilometros;
    float aceite,consumo_de_aceite;
    float consu_precio,gastos_totales;
    float conver_litros_galones5,galones5,litros2;

    printf("-----BIENVENIDO/A-----\n");
    printf("Ingrese el nombre del cliente: ");
    scanf("%s", nombre);

    printf("Ingrese la cantidad de kilometros recorridos: ");
    scanf("%f", &kilometros);

    printf("Ingrese la cantidad de litros de gasolina consumidos (minimo 8k maximo 16km): ");
    scanf("%f", &litros);
    printf("\n");

    printf("-----Gastos Varios-----");
    printf("\n");

    printf("Ingrese el pago mensual del seguro: ");
    scanf("%f", &pago_de_seguro);


    printf("Ingrese el precio de mantenimiento del vehiculo: ");
    scanf("%f", &mantenimineto);


    printf("Ingrese la cantidad de litros de aceite que usa el vehiculo: ");
    scanf("%f", &aceite);
    printf("\n");


    consu_precio = PRECIO_GALON / litros;
    consumo_de_aceite = aceite / kilometros;
    precio_de_manteniminto_por_kilometros = mantenimineto / kilometros;
    rendimiento = kilometros / litros;
    seguro_por_kilometros = pago_de_seguro / kilometros;
    gastos_totales = pago_de_seguro + mantenimineto + consu_precio ;

    printf("Cliente: %s\n", nombre);
    printf("Rendimiento de combustible: %.2f kilometros por litro\n", rendimiento);
    printf("Rendimiento de combustible en peso por kilometros es: %.2f pesos \n", consu_precio);
    printf("Pago de seguro por kilometros en pesos : %.2f \n", seguro_por_kilometros);
    printf("El precio de mantenimiento por kilometros es : %.2f \n",precio_de_manteniminto_por_kilometros);
    printf("La cantidad de aceite que consume el auto por kilometros es: %.2f litros por kilometros\n",consumo_de_aceite);
    printf("El total de gastos es: %.2f Pesos\n",gastos_totales);

    printf("\n-----GRACIAS POR CONFIAR EN NOSOTROS, VUELVA PRONTO-----\n\n");


 return 0;
}
