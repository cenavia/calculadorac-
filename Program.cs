using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Científica");
            Console.WriteLine("----------------------");

            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la operación (+, -, *, /, ^, sqrt): ");
            string op = Console.ReadLine();
        }
    }
}