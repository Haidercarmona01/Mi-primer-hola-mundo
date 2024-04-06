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
            //// Genera un número entre 0 y rangoMaximo
            numAleatorio = random.Next(rangoMaximo + 1);

            //Estas variables rastrean el número de intentos y si el juego ha terminado.
            int intentos = 0;
            bool juegoTerminado = false;

            //Comienza un bucle while para el juego actual,
            //Este bucle se ejecuta mientras el juego no haya terminado.
            while (!juegoTerminado)
            {
                // Este bucle se repite para cada jugador.
                for (int jugador = 1; jugador <= numJugadores; jugador++)
                {
                    // esta impresion Solicita al jugador que adivine un número:
                    Console.WriteLine($"Turno del Jugador {jugador}");
                    Console.Write("Ingrese un número para adivinar: ");
                    int numeroIngresado;
                    while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
                    {
                        // muestra error si el numero no es valido 
                        Console.Write("Error. Ingrese un número válido: ");
                    }
                    //permite los intentos necesarioas para alcanzar el juego 
                    intentos++;

                    if (numeroIngresado < numAleatorio)
                    {
                        //muestra si el numero es mayor
                        Console.WriteLine("MAYOR");
                    } 

                    else if (numeroIngresado > numAleatorio)
                    {
                        // verifica si el numero es menor 
                        Console.WriteLine("MENOR");
                    }
                    else
                    {
                        //te indica cuando ganas 
                        Console.WriteLine($"¡HAS GANADO, Jugador {jugador}!");
                        juegoTerminado = true;
                        break;
                    }
                }
            }
            // muestra el numero aleatoreo elegido y pregunta si desea jugar o finalizar 
            Console.WriteLine($"Número aleatorio: {numAleatorio}");
            Console.WriteLine($"Intentos totales: {intentos}");
            Console.Write("¿Desea jugar otra vez? (s/n): ");
            jugarOtraVez = Console.ReadLine().Trim().ToLower() == "s";
        }
        //si finaliza muestra mensaje de agradecimiento 
        Console.WriteLine("¡Gracias por jugar!");
    }
}