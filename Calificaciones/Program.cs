using System;

namespace CalificacionAlumno
{
    class Program
    {
        static void Main(string[] args)
        {
            double calificacionPracticas = 0,
                calificacionExamen = 0,
                calificacionTareas = 0;
            bool entradaValida;

            // Validación para calificación de prácticas
            do
            {
                Console.WriteLine("Introduce la calificación de las prácticas (0-10): ");
                entradaValida = Double.TryParse(Console.ReadLine(), out calificacionPracticas);
                if (!entradaValida || calificacionPracticas < 0 || calificacionPracticas > 10)
                {
                    Console.WriteLine(
                        "Entrada no válida. Asegúrate de introducir un número entre 0 y 10."
                    );
                }
            } while (!entradaValida || calificacionPracticas < 0 || calificacionPracticas > 10);

            // Validación para calificación de examen
            do
            {
                Console.WriteLine("Introduce la calificación del examen (0-10): ");
                entradaValida = Double.TryParse(Console.ReadLine(), out calificacionExamen);
                if (!entradaValida || calificacionExamen < 0 || calificacionExamen > 10)
                {
                    Console.WriteLine(
                        "Entrada no válida. Asegúrate de introducir un número entre 0 y 10."
                    );
                }
            } while (!entradaValida || calificacionExamen < 0 || calificacionExamen > 10);

            // Validación para calificación de tareas
            do
            {
                Console.WriteLine("Introduce la calificación de las tareas (0-10): ");
                entradaValida = Double.TryParse(Console.ReadLine(), out calificacionTareas);
                if (!entradaValida || calificacionTareas < 0 || calificacionTareas > 10)
                {
                    Console.WriteLine(
                        "Entrada no válida. Asegúrate de introducir un número entre 0 y 10."
                    );
                }
            } while (!entradaValida || calificacionTareas < 0 || calificacionTareas > 10);

            // Calculamos la calificación final con los porcentajes
            double calificacionFinal =
                (calificacionPracticas * 0.55)
                + (calificacionExamen * 0.30)
                + (calificacionTareas * 0.15);

            // Mostramos la calificación final
            Console.WriteLine(
                "\nLa calificación total del alumno es: " + calificacionFinal.ToString("F2")
            );

            // Esperamos a que el usuario presione una tecla para cerrar el programa
            Console.ReadKey();
        }
    }
}
