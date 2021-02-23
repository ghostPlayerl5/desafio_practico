using System;

namespace examen_ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 0;
            double price = 0;
            Console.WriteLine("Ingrese el precio del articulo");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de articulo");
            amount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Tota: $" + price * amount);
        }
    }
}
