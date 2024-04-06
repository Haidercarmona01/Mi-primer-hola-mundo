using System;
using System.Data;

namespace natillera_actualizada
{
    class Program
    {
        static void Main(string[] args)
        //imprimir el mensaje de bienvenida 
        {
            Console.WriteLine("¡Bienvenido a la Cooperativa Navideña!");
            // declaracion de una variable boleana
            bool continuar = true;
            //Inicia un bucle while que se ejecutará mientras la variable continuar sea verdadera.
            while (continuar)
            {
                // se piden los datos de los miembros de la natillera
                Console.WriteLine("\nIngrese los datos para el primer miembro:");
                Miembro miembro1 = ObtenerDatosMiembro();
                Console.WriteLine("\nIngrese los datos para el segundo miembro:");
                Miembro miembro2 = ObtenerDatosMiembro();

                Console.WriteLine("\n\n--- Registro de aportes ---");
                //nicia un bucle for que recorre los meses del año, desde enero (mes 1)
                //hasta diciembre (mes 12).
                for (int mes = 1; mes <= 12; mes++)
                {
                    Console.WriteLine($"\n--- Mes {mes} ---");
                    // Llama al método  para registrar los aportes
                    // del primer miembro en el mes actual del bucle. del primer y segundo mienmbro
                    RegistrarAportes(miembro1, mes);
                    RegistrarAportes(miembro2, mes);
                }
                //Imprime un mensaje indicando que se realizará la liquidación anual de las cuentas.
                Console.WriteLine("\n\n--- Liquidación anual ---");
                LiquidarAnualmente(miembro1, miembro2);
                //Lee la entrada del usuario para determinar si desean continuar con otro año
                Console.Write("\n¿Desea continuar con otro año? (s/n): ");
                continuar = Console.ReadLine().ToLower() == "s"
                    {

                }
                }
        }
    }
}
}


                
            
        
    




