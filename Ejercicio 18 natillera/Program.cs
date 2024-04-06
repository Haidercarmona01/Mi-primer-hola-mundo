using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Se definen algunas variables para llevar el seguimiento de los aportes,
        //rendimientos, bonos, intereses, multas y constantes del programa.
        decimal aporteTotal = 0;
        decimal rendimientoTotal = 0;
        decimal bonoTotal = 0;
        decimal interesesTotal = 0;
        int multasTotal = 0;
        const decimal BONO = 0.4M;
        const decimal MULTA = 20000M;

        bool volver = true;
        //Se crea un objeto Random para generar números aleatorios que
        //representarán las tasas de rendimiento mensual.
        Random random = new Random();

        //Se inicia un bucle while que permite al usuario realizar operaciones en la "natillera"
        //hasta que decida salir.
        while (volver)
        //Dentro del bucle while, se inicializan variables que llevarán el seguimiento de los
        //aportes, rendimientos, bonos, préstamos, intereses de préstamos y multas de cada mes.
        {
            decimal aporteMensual = 0;
            decimal rendimientoMensual = 0;
            decimal bonoMensual = 0;
            decimal prestamo = 0;
            decimal interesesPrestamo = 0;
            int multas = 0;

            for (int mes = 1; mes <= 12; mes++)
            {

            }
        }
    }
}