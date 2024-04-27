using System;

namespace EMPLEADOS_POO
{
    //CREACION DE CLASE EMPLEADO 
    class Empleado
    {
        // Atributos NOMBRES EDAD Y TOTAL VENTAS
        private string nombre;
        private int edad;
        private decimal totalVentas;

        // Constructor inicializa estos atributos al crear un nuevo objeto
        public Empleado(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.totalVentas = 0;
        }
        // Método para registrar ventas calcula el total de ventas multiplicando el número 
        //de ventas por su valor y actualiza el atributo
        public void RegistrarVentas(int numVentas, decimal valorVenta)
        {
            totalVentas += numVentas * valorVenta;
        }
        // Método para mostrar información del empleado imprime por consola el nombre 
        //del empleado, su edad y el total de ventas registradas
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Total de ventas: $" + totalVentas);
        }

        static void Main()
        {
            // Ejemplo de uso Registro el empleado y las 10 ventas a $40 cada una y tambien se mostrara la informacion del empleado

            Empleado empleado1 = new Empleado("Haider Carmona", 26);
            empleado1.RegistrarVentas(10, 40); 
            empleado1.MostrarInformacion(); 
        }
    }
}
