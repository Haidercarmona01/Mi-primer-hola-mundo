using System;

class Program
{
    static void Main()
    {
        bool calcularNuevamente;

        do
        {
            Console.WriteLine("Ingrese el número de pacientes:");
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine($"\nIngrese el peso del paciente {j + 1} (en kg):");
                double peso = double.Parse(Console.ReadLine());

                Console.WriteLine($"Ingrese la altura del paciente {j + 1} (en metros):");
                double altura = double.Parse(Console.ReadLine());

                double imc = peso / (altura * altura);
                string categoria = ObtenerCategoriaIMC(imc);

                Console.WriteLine($"El IMC del paciente {j + 1} es: {imc:F2}, Categoría: {categoria}");
            }

            Console.WriteLine("\n¿Desea calcular el IMC de otro grupo de pacientes? (s/n)");
            string respuesta = Console.ReadLine();

            calcularNuevamente = respuesta.ToLower() == "s";

        } while (calcularNuevamente);

        Console.WriteLine("Programa finalizado.");
    }

    static string ObtenerCategoriaIMC(double imc)
    {
        if (imc < 18.5)
        {
            return "Peso Insuficiente";
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            return "Peso Saludable";
        }
        else if (imc >= 25.0 && imc <= 29.9)
        {
            return "Sobrepeso";
        }
        else
        {
            return "Obesidad";
        }
    }
}
