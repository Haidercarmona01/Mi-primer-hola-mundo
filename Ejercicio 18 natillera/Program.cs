﻿using System;
using System.Net;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args) //PASCAL 
    {
        /*Realizar un algoritmo en C# para una Natillera Navideña que determina cuánto ahorrará una persona en el año 2024, si al final de cada mes deposita cantidades variables de dinero; además, calcular los rendimientos generados por el ahorro en cada mes, correspondientes a la tasa del momento estipulada por Banco De La República (Tasas generadas por la clase Random entre 0.1% y 5.0%). Si la tasa del mes es inferior al 1.5%, entonces la Natillera estará en capacidad de otorgarle un bono a esa persona correspondiente a 2/5 partes del ahorro de dicho mes.  

        Se quiere saber cuál fue la tasa estipulada por el Banco de La República, cuánto lleva ahorrado, cuánto se otorgó de bono (si aplica) y cuánto lleva de rendimiento en cada mes, además se quiere saber el ahorro total, el bono total, los rendimientos totales al cabo de un año, y la suma total neta que se le consignará a esa persona.

        La aplicación debe tener la funcionalidad de preguntar al usuario si quiere volver al inicio para determinar el ahorro y rendimientos del siguiente año. Si no, salirse del programa. */

        //Variables
        bool volver = true;
        const double BONO = 0.4; //Snake Case:Notación para constantes.

        while (volver)
        {
            decimal aporteMensual, rendimientoMensual, aporteTotal = 0, rendimientoTotal = 0, bonoMensual = 0, bonoTotal = 0, aporteTotalNeto, tasaMensual;
            string continuar;

            //Clase random
            Random random = new Random(); //Esta es la forma de instanciar una clase en objeto

            for (int mes = 1; mes <= 12; mes++)
            {
                Console.Write($"Ingrese la cantidad que desea ahorrar en el mes {mes}: ");
                aporteMensual = Convert.ToDecimal(Console.ReadLine());

                tasaMensual = (decimal)random.Next(1, 51) / 10;
                rendimientoMensual = aporteMensual * (tasaMensual / 100);

                if (tasaMensual < 3.5M)
                {
                    bonoMensual = aporteMensual * (decimal)BONO;
                    bonoTotal += bonoMensual;
                    bonoMensual = 0;
                }

                aporteTotal += aporteMensual;
                rendimientoTotal += rendimientoMensual;

                Console.Write($"MES {mes}\n" +
                              $"Aportes: {aporteMensual:C}\n" +
                              $"Tasa: {tasaMensual}%\n" +
                              $"Rendimientos: {rendimientoMensual:C}\n" +
                              $"Bono: {bonoMensual:C}\n" +
                              $"---------------------------------------\n" +
                              $" \n");
            }

            aporteTotalNeto = rendimientoTotal + aporteTotal + bonoTotal;

            Console.Write($"Aportes totales: {aporteTotal:C}\n" +
                          $"Rendimientos totales: {rendimientoTotal:C}\n" +
                          $"Bonos totales: {bonoTotal:C}\n" +
                          "--------------------------------\n" +
                          $"TOTAL NETO: {aporteTotalNeto:C}\n" +
                          $" \n");


            Console.WriteLine("¿Desea ingresra a la natillera para el siguiente año? (s/n)");
            continuar = Console.ReadLine().ToLower();
            if (continuar == "n") volver = false;
        }
    }
}