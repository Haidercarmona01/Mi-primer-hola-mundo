using System;

namespace vendedor_comision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracion de sueldo base y comision//
            double Base = 2000;
            double tasaComision = 0.10;


            double[] ventas = { 600000, 300000, 200000 };

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
                }
}
