using System;

namespace MultiplicarPorDos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string opcion;

            // Bucle que permite al usuario repetir el proceso de multiplicación
            while (true)
            {
                // Solicitamos un número al usuario
                Console.WriteLine("Introduce un número entero: ");
                if (int.TryParse(Console.ReadLine(), out numero)) // Verifica que el valor ingresado sea un número entero
                {
                    // Multiplicamos el número por 2
                    int resultado = numero * 2;

                    // Mostramos el resultado
                    Console.WriteLine($"El número {numero} multiplicado por 2 es: {resultado}\n");
                }
                else
                {
                    Console.WriteLine("¡Error! Debes ingresar un número entero válido.");
                    continue; // Si no se ingresa un número válido, el bucle vuelve a pedir el número.
                }

                // Preguntamos si el usuario quiere continuar
                Console.WriteLine("¿Quieres ingresar otro número? (S/N)");
                opcion = Console.ReadLine().ToUpper();

                // Si el usuario ingresa 'N', salimos del bucle
                if (opcion == "N")
                {
                    break; // Salir del bucle
                }
            }

            // Mensaje de despedida
            Console.WriteLine("\n¡Gracias por usar el programa!");
        }
    }
}
