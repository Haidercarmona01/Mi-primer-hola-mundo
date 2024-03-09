using System;

namespace velocidad_de_trenes_salida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // anotando la velocidad de los trenes//
            double velocidadPrimerTren = 80; // km/h
            double velocidadSegundoTren = 100; // km/h

            // midiendo la distancia recorrida//
            double distanciaInicial = velocidadPrimerTren; // km

            // Calcular el tiempo  la distancia recorrida por el primer tren para alcanzar al otro//
            double tiempoAlcance = CalcularTiempoAlcance(distanciaInicial, velocidadSegundoTren); 

            // Calcular la hora que lo alcanza//
            TimeSpan horaEncuentro = CalcularHoraEncuentro(tiempoAlcance);

            // Mostrar la hora de encuentro del segundo tren//
            Console.WriteLine($"El segundo tren alcanzará al primer tren a las {horaEncuentro.ToString(@"hh\:mm")}.");
            Console.ReadLine();
        }
        //  calcular el tiempo que le toma al tren alcanzar la distancia recorrida por el primer tren//
        static double CalcularTiempoAlcance(double distancia, double velocidad)
        {
            return distancia / velocidad;
        }
        // como calcular la hora de encuentro 
        static TimeSpan CalcularHoraEncuentro(double tiempo)
        {
            // Hora en que sale el tren
            TimeSpan horaInicial = TimeSpan.FromHours(08); 
            return horaInicial + TimeSpan.FromHours(tiempo);
        }
    }
}
