using System;

namespace examen_ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el tecer numero");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===");

            if (num1 > num2 && num1 > num3)
            {
                
                Console.WriteLine(num1);
                
            }
            else if (num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else if(num2<num3)
            {
                Console.WriteLine(num3);
            }

        }
        
    }
}
