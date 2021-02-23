using System;

namespace examen_ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el primer numero");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese el tercer numero");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese el cuarto numero");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("La suma de los dos primeros numeros es:");
            Console.WriteLine(num1 + num2);
            Console.WriteLine("El producto de los dos ultimos numeros es:");
            Console.WriteLine(num3*num4);
            Console.ReadKey();
        }
    }
}
