﻿using System;

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
    }
}
