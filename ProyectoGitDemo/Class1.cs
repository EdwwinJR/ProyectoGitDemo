using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGitDemo
{
    internal class Class1
    {
        // Método de suma
        public double Sumar(double a, double b)
        {
            return a + b;
        }

        // Método de resta
        public double Restar(double a, double b)
        {
            return a - b;
        }

        // Método de multiplicación
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        // Método de división (maneja división por cero)
        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("⚠️ Error: No se puede dividir entre cero.");
                return double.NaN;
            }
            return a / b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 calc = new Class1();

            Console.WriteLine("=== 🧮 Calculadora Básica ===");
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Suma: {calc.Sumar(num1, num2)}");
            Console.WriteLine($"Resta: {calc.Restar(num1, num2)}");
            Console.WriteLine($"Multiplicación: {calc.Multiplicar(num1, num2)}");
            Console.WriteLine($"División: {calc.Dividir(num1, num2)}");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }

}
}
