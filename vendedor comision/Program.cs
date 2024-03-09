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
        }
}
