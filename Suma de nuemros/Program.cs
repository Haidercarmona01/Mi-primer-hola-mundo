using System;

namespace Suma_de_nuemros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables 
            int acomuladorPar =0, acomuladorimpar=0;

            for (int i = 1; i <= 100; i++) 
            { 
                //mostrar los 100 primeros numeros 

                Console.WriteLine(i);
                //indentificar para acomular par o impar 
                if (i % 2 == 0) acomuladorPar += i;
                else acomuladorimpar += i;

            }
            Console.WriteLine($"la suma de los pares es : {acomuladorPar}");
            Console.WriteLine($"la suma de los pares es : {acomuladorimpar}");
        }
    }
}
