using System;

namespace SerieDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contador = 0;

            Console.WriteLine(
                "Introduce una serie de números distintos de cero. Para finalizar, ingresa un 0."
            );

            // Bucle que lee los números hasta que el usuario ingrese un 0
            do
            {
                Console.Write("Introduce un número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                // Solo se imprimen los números diferentes de cero
                if (numero != 0)
                {
                    Console.WriteLine("Número leído: " + numero);
                    contador++; // Incrementamos el contador de números leídos
                }
            } while (numero != 0); // El bucle termina cuando el usuario ingresa 0

            // Mostramos la cantidad de números leídos
            Console.WriteLine("\nTotal de números leídos: " + contador);
            Console.WriteLine("Programa terminado.");
        }
    }
}
