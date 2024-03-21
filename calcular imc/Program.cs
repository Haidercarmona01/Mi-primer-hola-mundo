using System;

class Program
{
    static void Main(string[] args)
    {
       //Se quiere crear un algoritmo en C# que calcule el IMC de N pacientes y luego lo clasifique dentro de una categoría:
       // -Si el IMC del paciente es menor a 18,5, entonces tiene peso insuficiente.
       //-Si el IMC está entre 18,5 y 24,9 se encuentre en la categoría de Peso Saludable
       //-Si el IMC está entre 25,0 y 29,9 entonces tiene sobrepeso
       //- Si el IMC es mayor de 29.9 entonces tiene obesidad.
       //Mostrar en pantalla la categoría de cada uno de los pacientes.La aplicación debe estar en capacidad de pedirle al usuario si quiere volver a calcular//


        do
        {
           //declaracion de variables del paciente

            Console.WriteLine("Ingrese el número de pacientes:");
            int cantidadPacientes = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadPacientes; i++)
            {
                Console.WriteLine($"\nPaciente {i + 1}:");
                Console.Write("Ingrese la masa corporal en kilogramos: ");
                double masaCorporal = double.Parse(Console.ReadLine());
                Console.Write("Ingrese la altura en metros: ");
                double altura = double.Parse(Console.ReadLine());

                double indiceMasaCorporal = CalcularIMC(masaCorporal, altura);
                string categoriaIMC = ClasificarIMC(indiceMasaCorporal);

                Console.WriteLine($"Índice de Masa Corporal: {indiceMasaCorporal:F2}, Categoría: {categoriaIMC}");
            }

      
        }
    }
}
