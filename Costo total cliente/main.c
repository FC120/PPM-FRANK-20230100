/*#include <stdio.h>
#define PRECIO_GALON 192.00

    int main()
    {
    char p1;
    FILE *ar;
    ar = fopen("Cliente.txt", "w");


    char nombre[50];
    float kilometros, litros,rendimiento,pago_de_seguro,seguro_por_kilometros,mantenimineto,precio_de_manteniminto_por_kilometros,aceite,consumo_de_aceite,consu_precio,gastos_totales;

    printf("-----BIENVENIDO/A-----\n");
    printf("Ingrese el nombre del cliente: ");
    scanf("%s", nombre);

    if(ar != NULL)
    {

        while ((p1=getchar()) != '\n')


        fclose(ar);



   /* printf("-----BIENVENIDO/A-----\n");
    printf("Ingrese el nombre del cliente: ");
    scanf("%s", nombre);

    printf("Ingrese la cantidad de kilometros recorridos: ");
    scanf("%f", &kilometros);

    printf("Ingrese la cantidad de litros de gasolina consumidos: ");
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

    }

    consu_precio = PRECIO_GALON / litros;
    consumo_de_aceite = aceite / kilometros;
    precio_de_manteniminto_por_kilometros = mantenimineto / kilometros;
    rendimiento = kilometros / litros;
    seguro_por_kilometros = pago_de_seguro / kilometros;
    gastos_totales = pago_de_seguro + mantenimineto + consu_precio ;

    printf("-----------------------------|Cliente|-----------------------------: \n   \t\t\t%s\n\n", nombre);


    printf("Distancia\tCombustible\tGastos Varios\t\tTotal\n");
    printf("%.2f\t\t%.2f\t\t%.2f\t%.2f\t%.2f\t%.2f\n", rendimiento, consu_precio, seguro_por_kilometros, precio_de_manteniminto_por_kilometros, consumo_de_aceite, gastos_totales);




   /* printf("Rendimiento de combustible: %.2f kilometros por litro\n", rendimiento);
    printf("Rendimiento de combustible en peso por kilometros es: %.2f pesos \n", consu_precio);
    printf("Pago de seguro por kilometros en pesos : %.2f \n", seguro_por_kilometros);
    printf("El precio de mantenimiento por kilometros es : %.2f \n",precio_de_manteniminto_por_kilometros);
    printf("La cantidad de aceite que consume el auto por kilometros es: %.2f litros por kilometros\n",consumo_de_aceite);
    printf("El total de gastos es: %.2f Pesos\n",gastos_totales);

    printf("\n-----GRACIAS POR CONFIAR EN NOSOTROS, VUELVA PRONTO-----\n\n");


 return 0;
}

*/
#include <stdio.h>

int main() {
    char cliente[50];
    float km_recorridos;
    float precio_combustible;
    float cambio_aceite;
    float cambio_filtros;
    float cambio_bandas;
    float seguro;
    float precio_gomas;
    float consumo_max = 16.0;
    float consumo_min = 8.0;
    float precision = 1.0;
    float precio_gasolina = 193.0;
    float litros_por_galon = 3.78541;

    printf("POR FAVOR MAXIMIZAR VENTANA\n");
    printf("Ingrese el nombre del cliente: ");
    //scanf("%s", cliente);
    fgets(cliente, sizeof(cliente), stdin);

     int i = 0;
    while (cliente[i] != '\0')
        {
        if (cliente[i] == '\n')
        {
            cliente[i] = '\0';
            break;
        }
        i++;
    }

    //printf("Nombre: %s\n", cliente);
    //printf("Apellido: %s\n", cliente + i + 1);


    printf("Ingrese los kilómetros recorridos: ");
    scanf("%f", &km_recorridos);

    printf("Ingrese el precio del combustible: ");
    scanf("%f", &precio_combustible);

    printf("Ingrese el costo del cambio de aceite: ");
    scanf("%f", &cambio_aceite);

    printf("Ingrese el costo del cambio de filtros: ");
    scanf("%f", &cambio_filtros);

    printf("Ingrese el costo del cambio de bandas: ");
    scanf("%f", &cambio_bandas);

    printf("Ingrese el costo del seguro anual: ");
    scanf("%f", &seguro);

    printf("Ingrese el costo de las gomas: ");
    scanf("%f", &precio_gomas);

    // Cálculo de los gastos varios
    float gastos_mantenimiento = cambio_aceite + cambio_filtros + cambio_bandas;
    float gastos_varios_km = gastos_mantenimiento + seguro + (precio_gomas * km_recorridos);
    float gastos_totales = gastos_varios_km * km_recorridos;

    // Cálculo del costo total
    float costo_total = 0.0;

    char p1;
    FILE *ar = fopen("Freddy Guerrero.txt", "w");
    if (ar == NULL)
    {
        printf("No se pudo abrir el archivo.\n");
        return 1;
    }

    printf("\n------------------------------------------------------------------------------------|Cliente|------------------------------------------------------------------------------------- \n   \t\t\t\t\t\t\t\t\t\t%s\n\n", cliente);
    printf("\nL/100\nConsumo promedio\tNombre\t\t\tKM/Galon\tCombustible costo x km\t\tGastos varios x km\tPrecio x galon\t\tCosto Total\t\tKM\n");

    fprintf(ar, "\n------------------------------------------------------------------------------------|Cliente|------------------------------------------------------------------------------------- \n   \t\t\t\t\t\t\t\t\t\t%s\n\n", cliente);
    fprintf(ar, "\nL/100\nConsumo promedio\tNombre\t\t\tKM/Galon\tCombustible costo x km\t\tGastos varios x km\tPrecio x galon\t\tCosto Total\t\tKM\n");

    for (float consumo_promedio = consumo_min; consumo_promedio <= consumo_max; consumo_promedio += precision) {
        float consumo = 100.0 / (litros_por_galon / consumo_promedio);
        float km_por_galon = litros_por_galon * consumo_promedio;
        costo_total = precio_combustible * km_recorridos / km_por_galon + gastos_totales;

        printf("%.1f\t\t\t%s\t\t%.2f\t\t\t%.2f\t\t\t\t%.2f\t\t\t%.2f\t\t\t%.2f\t\t%.2f\t\t\n",
               consumo_promedio, cliente, km_por_galon, precio_combustible * km_recorridos / km_por_galon,
               gastos_varios_km, precio_combustible, costo_total, km_recorridos);

        fprintf(ar, "%.1f\t\t\t%s\t\t%.2f\t\t\t%.2f\t\t\t\t%.2f\t\t\t%.2f\t\t\t%.2f\t\t%.2f\t\t\n",
                consumo_promedio, cliente, km_por_galon, precio_combustible * km_recorridos / km_por_galon,
                gastos_varios_km, precio_combustible, costo_total, km_recorridos);

        printf("\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- \n   \t\t\t\t\t\t\t\t\t\n\n");

    }
    fclose(ar);
    printf("\nLos resultados se han guardado correctamente en el archivo Freddy Guerrero.txt.\n");
    printf("\n-----GRACIAS POR CONFIAR EN NOSOTROS, VUELVA PRONTO-----\n\n");

    return 0;
}
