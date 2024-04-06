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
                continuar = Console.ReadLine().ToLower() == "s";
                    
                     }

            Console.WriteLine("\n¡Gracias por utilizar la Cooperativa Navideña!");
        }
        // Solicita al usuario que ingrese los datos para el  miembro de la cooperativa.
        static Miembro ObtenerDatosMiembro()
        {
            Console.Write("Nombre del miembro: ");
            string nombre = Console.ReadLine();
            //solicita la cantidad aportada 
            Console.Write("Cantidad aportada en enero: $");
            double aporteEnero = double.Parse(Console.ReadLine());
            return new Miembro(nombre, aporteEnero);
        }

        static void RegistrarAportes(Miembro miembro, int mes)
        {
            //pide los paortes
            Console.WriteLine($"\nAportes del miembro {miembro.Nombre} para el mes {mes}:");
            Console.Write("Cantidad aportada: $");
            double aporte = double.Parse(Console.ReadLine());

            if (aporte == 0)
            { 
                // se indican las multas aplicadas 
                Console.WriteLine("¡Multa aplicada! Se le cobrará $20,000.");
                miembro.AplicarMulta();
            }
            else
            {
                miembro.RealizarAporte(aporte);
                // se deja indicado si desea o no realizar un prestamo 
                Console.Write("¿Desea solicitar un préstamo? (s/n): ");
                if (Console.ReadLine().ToLower() == "s")
                {
                    Console.Write("Cantidad del préstamo: $");
                    double montoPrestamo = double.Parse(Console.ReadLine());
                    miembro.SolicitarPrestamo(montoPrestamo);
                }
            }
        }

        static void LiquidarAnualmente(Miembro miembro1, Miembro miembro2)
        {
            Console.WriteLine($"\nMiembro {miembro1.Nombre}:");
            miembro1.Liquidar();
            Console.WriteLine($"\nMiembro {miembro2.Nombre}:");
            miembro2.Liquidar();
        }
    }

    class Miembro
    {
        public string Nombre { get; }
        public double AhorroTotal { get; private set; }
        public double MultasPagadas { get; private set; }
        public double Prestamo { get; private set; }

        public Miembro(string nombre, double aporteEnero)
        {
            Nombre = nombre;
            AhorroTotal = aporteEnero;
        }

        public void RealizarAporte(double cantidad)
        {
            AhorroTotal += cantidad;
        }

        public void AplicarMulta()
        {
            AhorroTotal -= 20000;
            MultasPagadas += 1;
        }

        public void SolicitarPrestamo(double monto)
        {
            if (monto <= AhorroTotal)
            {
                Prestamo += monto;
                AhorroTotal -= monto;
                Console.WriteLine("¡Préstamo aprobado!");
            }
            else
            {
                Console.WriteLine("¡Préstamo no aprobado! El monto solicitado excede el ahorro acumulado.");
            }
        }

        public void Liquidar()
        {
            double intereses = CalcularIntereses(Prestamo);

            Console.WriteLine($"Ahorro total: ${AhorroTotal}");
            Console.WriteLine($"Multas pagadas: {MultasPagadas}");
            Console.WriteLine($"Monto del préstamo: ${Prestamo}");
            Console.WriteLine($"Intereses generados por el préstamo: ${intereses}");
            Console.WriteLine($"Total neto a liquidar: ${(AhorroTotal - Prestamo) + intereses}");
        }

        private double CalcularIntereses(double prestamo)
        {
            double tasaInteresMensual = 0.025; // 2.5% mensual
            return prestamo * tasaInteresMensual * 7; // Interés acumulado de 7 meses
        }
    
    }
}










