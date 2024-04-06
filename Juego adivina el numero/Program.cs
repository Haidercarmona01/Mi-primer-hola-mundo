//Desarrollar el juego “Adivina el número” en un programa de C#. El juego es muy sencillo, consiste en
//adivinar un número ℕ aleatorio que el sistema escoge de un determinado rango y lo guarda en
//memoria sin ser revelado.
//El juego debe tener la funcionalidad de escoger el número de participantes que jugarán: mínimo 2 y
//máximo 4 integrantes. Dependiendo de la cantidad de jugadores, el número ℕ aleatorio se generará
//en los siguientes rangos:

using System;

class Program
{
    static void Main()
    {
        //Esto crea un generador de números aleatorios que se
        //utilizará para elegir el número que los jugadores deben adivinar.
        Random random = new Random();
        //Inicializa una variable  Esta variable controla si el
        //juego debe repetirse después de que se complete una partida.
        bool jugarOtraVez = true;

        //Este bucle se ejecuta mientras la variable jugarOtraVez sea verdadera,
        while (jugarOtraVez)
        {
            //Estas líneas borran la consola y muestran un mensaje de bienvenida al juego.

            Console.Clear();
            Console.WriteLine("¡Bienvenido al juego 'Adivina el número'!");
            Console.Write("Ingrese el número de jugadores (entre 2 y 4): ");

            int numJugadores;
            //int.TryPar convierte la precentacion en cadena y Utiliza un bucle while
            //para leer la entrada del usuario y validar que sea un
            //número entre 2 y 4. Si la entrada no es válida, se solicita al usuario que
            //ingrese nuevamente un número válido.
            while (!int.TryParse(Console.ReadLine(), out numJugadores) || numJugadores < 2 || numJugadores > 4)
            {
                //presenta en pantalla si el numero ingresado no esta en el rango
                Console.Write("Error. Ingrese un número válido de jugadores (entre 2 y 4): ");
            }
            //Genera un número aleatorio entre 0 y el valor de rangoMaximo
            int numAleatorio;
            //Utiliza una expresión switch para determinar el rango máximo en función del
            //número de jugadores elegido por el usuario.
            int rangoMaximo = numJugadores switch
            {
                2 => 50,
                3 => 100,
                4 => 200,
                _ => 0 // Esto no debería ocurrir si el input está validado
            };
        
        }
    }


}
