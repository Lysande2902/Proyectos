using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el número de triángulos que desea calcular: ");
        int numTriangulos = LeerEntero();

        for (int i = 1; i <= numTriangulos; i++)
        {
            Console.WriteLine($"\nTriángulo {i}");

            // Leer los lados del triángulo con validación
            double a = LeerDouble("Ingrese el lado a: ");
            double b = LeerDouble("Ingrese el lado b: ");
            double c = LeerDouble("Ingrese el lado c: ");

            // Validar si los lados forman un triángulo
            if (EsTrianguloValido(a, b, c))
            {
                // Calcular el área usando la fórmula de Herón
                double p = (a + b + c) / 2;
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"El área del triángulo es: {area:F2}");

                // Determinar el tipo de triángulo
                string tipoTriangulo = ClasificarTriangulo(a, b, c);
                Console.WriteLine($"El triángulo es: {tipoTriangulo}");
            }
            else
            {
                Console.WriteLine("Los lados ingresados no forman un triángulo válido.");
            }
        }
    }

    static int LeerEntero()
    {
        int resultado;
        while (true)
        {
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out resultado) && resultado > 0)
            {
                return resultado;
            }
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo:");
        }
    }

    static double LeerDouble(string mensaje)
    {
        double resultado;
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();
            if (double.TryParse(entrada, out resultado) && resultado > 0)
            {
                return resultado;
            }
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido:");
        }
    }

    static bool EsTrianguloValido(double a, double b, double c)
    {
        // Un triángulo es válido si cumple la desigualdad triangular
        return a + b > c && a + c > b && b + c > a;
    }

    static string ClasificarTriangulo(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "Equilátero"; // Todos los lados son iguales
        }
        else if (a == b || a == c || b == c)
        {
            return "Isósceles"; // Dos lados son iguales
        }
        else
        {
            return "Escaleno"; // Todos los lados son diferentes
        }
    }
}
