using System;

namespace examen_ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la primera nota");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese la segunda nota");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese la tercera nota ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double prom = (num1 + num2 + num3) / 3;

            if (prom >= 7)
            {
                Console.WriteLine("Promocionado");
            }
            else if (prom >= 4)
            {
                Console.WriteLine("regular");
            }
            else if (prom < 4)
            {
                Console.WriteLine("reprobado");

            }
        }
    }
}
