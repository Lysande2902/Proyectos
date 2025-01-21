using System;

namespace VelocidadCorredores
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos,
                segundos;
            double tiempoEnSegundos,
                velocidad;
            const double distancia = 1500; // Distancia en metros (1500 metros)

            Console.WriteLine(
                "Introduce el tiempo de los corredores en formato (minutos, segundos)."
            );
            Console.WriteLine("Para terminar, ingresa (0, 0).");

            // Bucle para leer los tiempos de los corredores
            while (true)
            {
                Console.Write("Introduce los minutos: ");
                minutos = Convert.ToInt32(Console.ReadLine());

                Console.Write("Introduce los segundos: ");
                segundos = Convert.ToInt32(Console.ReadLine());

                // Verificamos si la entrada es (0, 0), lo cual termina el ciclo
                if (minutos == 0 && segundos == 0)
                {
                    break;
                }

                // Convertimos el tiempo a segundos
                tiempoEnSegundos = minutos * 60 + segundos;

                // Calculamos la velocidad en m/s
                velocidad = distancia / tiempoEnSegundos;

                // Imprimimos el tiempo y la velocidad
                Console.WriteLine($"Tiempo: {minutos} minutos y {segundos} segundos");
                Console.WriteLine($"Velocidad: {velocidad:F2} metros por segundo\n");
            }

            Console.WriteLine("Programa terminado.");
        }
    }
}
