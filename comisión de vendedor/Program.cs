using System;

namespace vendedor_comision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracion de sueldo base y comision//
            double Base = 4000;
            double tasaComision = 0.10;


            double[] ventas = { 600000, 400000, 200000 };

            double comisiones = 0;
            foreach (double venta in ventas)
            {
                //operacion matematica para calcular comisiones//
                comisiones += venta * tasaComision;
            }
            //total de base mas comiciones//
            double total = Base + comisiones;

            //operacion para calcular la mayor comision//
            double mayorComision = 0;
            foreach (double venta in ventas)
            {
                // 5 actualizacion para calcular comision si es igual a la venta mas la tasa de comision y verificar si cumple con el if si es igual la venta para la comision//
                double comisionVenta = venta * tasaComision;
                if (comisionVenta > mayorComision)
                {
                    mayorComision = comisionVenta;
                }
            }


            double promedioComisiones = comisiones / ventas.Length;


            double totalVentas = 0;
            foreach (double venta in ventas)
            {
                totalVentas += venta;
            }
            bool objetivo = totalVentas >= 1000000;


            if (objetivo)
            {
                total += 100000;
                //vamos a escribir  si cumplio con el odjetivo//
                Console.WriteLine("¡Felicidades! Has superado el objetivo del mes y ganaste un beneficio extra de $100.000");
            }
            else
            {
                //vamos a escribir si no supero el objetivo//
                Console.WriteLine("No has superado el objetivo del mes.");
            }

            //vamos a escribir el total de comisiones por venta//
            Console.WriteLine($"Total de comisiones por las tres ventas: ${comisiones}");
            //vamos a escribir el salario total alcanzado//
            Console.WriteLine($"Salario total en el mes: ${total}");
            // vamos a escribir cual fue la mayor comision//
            Console.WriteLine($"Monto de la venta que generó la mayor comisión: ${mayorComision}");
            //vamos a escrinir el promeddio de comisiones
            Console.WriteLine($"Promedio de comisiones por venta: ${promedioComisiones}");

            Console.ReadLine();
        }
    }

}