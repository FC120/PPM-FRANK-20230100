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
    scanf("%s", cliente);

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

    // Cálculo del consumo promedio y costo total
    float consumo_promedio = 0.0;
    float costo_total = 0.0;
    float km_por_galon = 0.0;

     FILE *archivo = fopen("resultados.txt", "w");
    if (archivo == NULL)
    {
        printf("No se pudo abrir el archivo.\n");
        return 1;
    }

    printf("\n-----------------------------------------------------------------------|Cliente|------------------------------------------------------------------------------------: \n   \t\t\t\t\t\t\t\t\t%s\n\n", cliente);
    printf("\nL/100\nConsumo promedio\tNombre\t\tKM/Galon\tCombustible costo x km\t\tGastos varios x km\tPrecio x galon\t\tCosto Total\t\tKM\n");

    for (float consumo = consumo_max; consumo >= consumo_min; consumo -= precision)
        {
        km_por_galon = litros_por_galon * 100 / consumo;
        consumo_promedio = (consumo_max + consumo_min) / 2;
        costo_total = precio_combustible * km_recorridos / km_por_galon + gastos_totales;

        printf("%.1f\t\t\t%s\t\t%.2f\t\t\t%.2f\t\t\t\t%.2f\t\t\t%.2f\t\t%.2f\t\t\t%.2f\t\t\n",
            consumo_promedio, cliente, km_por_galon, precio_combustible * km_recorridos / km_por_galon,
            gastos_varios_km, precio_combustible, costo_total, km_recorridos);
    }

    fclose(archivo);
    printf("\n\nLos resultados se han guardado en el archivo resultados.txt.\n");
    printf("\n-----GRACIAS POR CONFIAR EN NOSOTROS, VUELVA PRONTO-----\n\n");

    return 0;
}
