using System;
using System.Linq;

namespace NumeroImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

            var pares = from
                    par in numeros
                      where (par % 2) == 0
                         select par;

            var impares = numeros.Except(pares);

            if (pares != null)
            {
                Console.WriteLine("::. O array não possui somente números impares .::");
                Console.WriteLine("Os números ímpares são:");
                foreach (var item in impares)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Os números pares são:");
                foreach (var item in pares)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("::. O console possui somente números ímpares .::");
                Console.WriteLine("Os números ímpares são:");
                foreach (var item in impares)
                {
                    Console.Write(item);
                }
            }
        }
    }
}
