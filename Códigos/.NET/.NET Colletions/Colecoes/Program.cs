using System;
using System.Linq;
using System.Collections.Generic;

namespace Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista

            /*
            List<string> estados = new List<string>();
            estados.Add("Brasil");
            estados.Add("Brasil Fake");

            Console.WriteLine(estados.Count);

            foreach (var item in estados)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("============");

            estados.Remove("Brasil Fake");

            foreach (var item in estados)
            {
                System.Console.WriteLine(item);
            }
            */


            //Dictionary

            /*
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("SP", "São Paulo");
            estados.Add("PR", "Paraná");

            foreach (var item in estados)
            {
                System.Console.WriteLine($"Chave {item.Key}, valor: {item.Value}");
            }

            string valorProcurado = "PR";
            System.Console.WriteLine(estados[valorProcurado]);
            */

            //LINQ
            int[] arrayNumeros = new int[5] { 1, 4, 8, 15, 19 };

            //Chamada por consulta
            var numerosPares =
                from num in arrayNumeros
                where num % 2 == 0
                orderby num
                select num;
            
            //Chamada por metodo
            var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            System.Console.WriteLine("Numeros pares query: " + string.Join(", ", numerosPares));
            System.Console.WriteLine("Numeros pares metodo: " + string.Join(", ", numerosParesMetodo));

            int[] arrayNovosNumeros = new int[10] { 100, 1, 4, 0, 8, 15, 19, 19, 4, 100 };
            var minimo = arrayNovosNumeros.Min();
            var maximo = arrayNovosNumeros.Max();
            var medio = arrayNovosNumeros.Average();
            var soma = arrayNovosNumeros.Sum();
            var arrayUnico = arrayNovosNumeros.Distinct().ToArray();

            System.Console.WriteLine($"Minimo {minimo} Maximo {maximo} Medio {medio}");
            System.Console.WriteLine($"Soma {soma}");
            System.Console.WriteLine($"Distintos {string.Join(", ", arrayUnico) }");
        }
    }
}