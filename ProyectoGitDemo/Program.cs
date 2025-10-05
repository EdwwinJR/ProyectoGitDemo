using System;

namespace ProyectoGitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Proyecto Git Demo - Menú Principal";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== 🧩 MENÚ PRINCIPAL ===");
                Console.WriteLine("1. Mostrar 'Hello World'");
                Console.WriteLine("2. Ejecutar Calculadora 🧮");
                Console.WriteLine("3. Salir");
                Console.Write("\nSelecciona una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MostrarHelloWorld();
                        break;

                    case "2":
                        EjecutarCalculadora();
                        break;

                    case "3":
                        Console.WriteLine("\n👋 ¡Hasta luego!");
                        return;

                    default:
                        Console.WriteLine("\n⚠️ Opción inválida. Inténtalo otra vez.");
                        break;
                }

                Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
        }

        static void MostrarHelloWorld()
        {
            Console.Clear();
            Console.WriteLine("🌍 Hello, World!");
        }

        static void EjecutarCalculadora()
        {
            Console.Clear();
            var calc = new Claculada.Calculadora(); // usa tu clase de calculadora

            Console.WriteLine("=== 🧮 Calculadora Básica ===");
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Suma: {calc.Sumar(num1, num2)}");
            Console.WriteLine($"Resta: {calc.Restar(num1, num2)}");
            Console.WriteLine($"Multiplicación: {calc.Multiplicar(num1, num2)}");
            Console.Write
