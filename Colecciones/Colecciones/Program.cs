using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>();   
            int n = 0;
            int r = 0;

            valores.Add(7);
            valores.Add(5);
            valores.Add(4);
            valores.Add(3);
            valores.Add(8);
            valores.Add(9);

            //Recorremos con ciclo for
            for (n = 0; n < valores.Count; n++)
            {
                //No hay necesidad de type cast
                r = valores[n];
                Console.WriteLine(r);
            }
            Console.WriteLine("-----");

            //Vemos si contiene a determinado elemento
            Console.WriteLine(valores.Contains<int>(5));
            Console.WriteLine(valores.Contains<int>(17));

            Console.WriteLine("-----");

            //Obtenemos indice de un elemento
            Console.WriteLine(valores.IndexOf(4));

            Console.WriteLine("------");

            //Insertamos el elemento indice 
            valores.Insert(2, 55);

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("-------");

            //Eliminamos elemento en un indice 
            valores.RemoveAt(3);

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("-------");

            //Eliminamos la primera ocurrencia de un valor
            valores.Remove (8);

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("--------");

            //La lista se coloca en sentido contrario
             valores.Reverse(); 

        }
    }
}
