using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Program
{
    static void Main(string[] args)

    {
        List<int> numeros = new List<int>(); //DECLARACION DE LISTTA DE TIPO (COLECCION)



        Console.WriteLine("Introduce el elemento en la consala (0para salir )");
        int elem = 1;

        while (elem != 0)
        {
            elem = Int32.Parse(Console.ReadLine());
            numeros.Add(elem);

        }
        numeros.Remove(numeros.Count - 1);

        Console.WriteLine("elementos de introducion:");

        foreach (int elemento in numeros)
        {
            Console.WriteLine(elemento);
        }
    }
}

