using System;

namespace examen_ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double gerente = 0.10;
            double asistente = 0.05;
            double secretaria = 0.03;
            double otros = 0.02;

            //datos del primer empleado
            Console.WriteLine("\nDigite los datos del primer empleado");

            Console.WriteLine("\nNombre completo del empleado");
            string name = Console.ReadLine();

            Console.WriteLine("\ncargo del empleado (digitelo con el numero que le pertenece a cada cargo(1.gerente,2.asistente o 3.secretaria 4.otros)");
            int title = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nhoras trabajadas(no se permiten valores negativos)");
            int h = Convert.ToInt32(Console.ReadLine());

            //datos del segundo empleado
            Console.WriteLine("\nDigite los datos del segundo empleado");

            Console.WriteLine("\nNombre completo del empleado");
            string name2 = Console.ReadLine();

            Console.WriteLine("\ncargo del empleado (digitelo con el numero que le pertenece a cada cargo(1.gerente,2.asistente o 3.secretaria 4.otros)");
            int title2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nhoras trabajadas(no se permiten valores negativos)");
            int h2 = Convert.ToInt32(Console.ReadLine());

            //datos del tercer empleado
            Console.WriteLine("\nDigite los datos del tercer empleado");

            Console.WriteLine("\nNombre completo del empleado");
            string name3 = Console.ReadLine();

            Console.WriteLine("\ncargo del empleado (digitelo con el numero que le pertenece a cada cargo(1.gerente,2.asistente o 3.secretaria 4.otros)");
            int title3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nhoras trabajadas(no se permiten valores negativos)");
            int h3 = Convert.ToInt32(Console.ReadLine());

            if (h <= 0 && h2 <= 0 && h3<= 0)
            {
                Console.WriteLine("no se puede ejecutar");
                Console.WriteLine("saliendo del programa...");
                Console.ReadKey();            
            }



            if (h <= 160)
            {
                double Salhn = h * 9.75;

                double ISSn1 = Salhn * 0.0535;
                double AFPn1 = Salhn * 0.0688;
                double RENTAn1 = Salhn * 0.10;
                double descn1 = ISSn1 + AFPn1 + RENTAn1;
                double SalLiquidn1 = Salhn-descn1;
                if (title == 1)
                {
                    double Salwbonn1 = SalLiquidn1 / 0.10;
                    Console.WriteLine("nombre del empleado:" + name + "\nDescuento del ISS:" + ISSn1 + "\nDescuento del AFP:" + AFPn1 + "\nDescuento De Renta:" + RENTAn1 + "\nSueldo Liquido:" + Salwbonn1);
                    Console.WriteLine("");
                }
                else if (title == 2)
                {
                    double Salwbonn1 = SalLiquidn1 / 0.05;
                    Console.WriteLine("nombre del empleado:" + name + "\nDescuento del ISS:" + ISSn1 + "\nDescuento del AFP:" + AFPn1 + "\nDescuento De Renta:" + RENTAn1 + "\nSueldo Liquido:" + Salwbonn1);
                    Console.WriteLine("");
                }
                else if (title == 3)
                {
                    double Salwbonn1 = SalLiquidn1 / 0.03;
                    Console.WriteLine("nombre del empleado:" + name + "\nDescuento del ISS:" + ISSn1 + "\nDescuento del AFP:" + AFPn1 + "\nDescuento De Renta:" + RENTAn1 + "\nSueldo Liquido:" + Salwbonn1);
                    Console.WriteLine("");
                }
                else if (title == 4)
                {
                    double Salwbonn1 = SalLiquidn1 / 0.02;
                    Console.WriteLine("nombre del empleado:" + name + "\nDescuento del ISS:" + ISSn1 + "\nDescuento del AFP:" + AFPn1 + "\nDescuento De Renta:" + RENTAn1 + "\nSueldo Liquido:" + Salwbonn1);
                    Console.WriteLine("");
                }

            }
            else if (h > 160)
            {
                double Salhm = h * 9.15 + ((h - 160) * 11.50);
                double ISSm1 = Salhm * 0.0535;
                double AFPm1 = Salhm * 0.0688;
                double RENTAm1 = Salhm * 0.10;
                double descm1 = ISSm1 + AFPm1 + RENTAm1;
                double SalLiquidm1 = Salhm - descm1;
                if (title == 1)
                {
                    double Salwbonm1 = SalLiquidm1 / 0.10;
                    Console.WriteLine("nombre del empleado:" + name + "\nDescuento del ISS:" + ISSm1 + "\nDescuento del AFP:" + AFPm1 + "\nDescuento De Renta:" + RENTAm1 + "\nSueldo Liquido:" + Salwbonm1);
                    Console.WriteLine("");
                }
                else if (title == 2)
                {
                    double Salwbonm1 = SalLiquidm1 / 0.05;
                    Console.WriteLine("nombre del empleado:" + name + "\nDescuento del ISS:" + ISSm1 + "\nDescuento del AFP:" + AFPm1 + "\nDescuento De Renta:" + RENTAm1 + "\nSueldo Liquido:" + Salwbonm1);
                    Console.WriteLine("");
                }
                else if (title == 3)
                {
                    double Salwbonm1 = SalLiquidm1 / 0.03;
                    Console.WriteLine("nombre del empleado:" + name + "\nDescuento del ISS:" + ISSm1 + "\nDescuento del AFP:" + AFPm1 + "\nDescuento De Renta:" + RENTAm1 + "\nSueldo Liquido:" + Salwbonm1);
                    Console.WriteLine("");
                }
                else if (title == 4)
                {
                    double Salwbonm1 = SalLiquidm1 / 0.02;
                    Console.WriteLine("nombre del empleado:" + name + "\nDescuento del ISS:" + ISSm1 + "\nDescuento del AFP:" + AFPm1 + "\nDescuento De Renta:" + RENTAm1 + "\nSueldo Liquido:" + Salwbonm1);
                    Console.WriteLine("");
                }
            }

            if (h2 <= 160)
            {
                double Salhn2 = h2 * 9.75;
                double ISSn2 = Salhn2 * 0.0535;
                double AFPn2 = Salhn2 * 0.0688;
                double RENTAn2 = Salhn2 * 0.10;
                double descn2 = ISSn2 + AFPn2 + RENTAn2;
                double SalLiquidn2 = Salhn2-descn2;
                if (title == 1)
                {
                    double Salwbonn2 = SalLiquidn2 / 0.10;
                    Console.WriteLine("nombre del empleado:" + name2 + "\nDescuento del ISS:" + ISSn2 + "\nDescuento del AFP:" + AFPn2 + "\nDescuento De Renta:" + RENTAn2 + "\nSueldo Liquido:" + Salwbonn2);
                    Console.WriteLine("");
                }
                else if (title == 2)
                {
                    double Salwbonn2 = SalLiquidn2 / 0.05;
                    Console.WriteLine("nombre del empleado:" + name2 + "\nDescuento del ISS:" + ISSn2 + "\nDescuento del AFP:" + AFPn2 + "\nDescuento De Renta:" + RENTAn2 + "\nSueldo Liquido:" + Salwbonn2);
                    Console.WriteLine("");
                }
                else if (title == 3)
                {
                    double Salwbonn2 = SalLiquidn2 / 0.03;
                    Console.WriteLine("nombre del empleado:" + name2 + "\nDescuento del ISS:" + ISSn2 + "\nDescuento del AFP:" + AFPn2 + "\nDescuento De Renta:" + RENTAn2 + "\nSueldo Liquido:" + Salwbonn2);
                    Console.WriteLine("");
                }
                else if (title == 4)
                {
                    double Salwbonn2 = SalLiquidn2 / 0.02;
                    Console.WriteLine("nombre del empleado:" + name2 + "\nDescuento del ISS:" + ISSn2 + "\nDescuento del AFP:" + AFPn2 + "\nDescuento De Renta:" + RENTAn2 + "\nSueldo Liquido:" + Salwbonn2);
                    Console.WriteLine("");
                }
            }
            else if (h2 > 160)
            {
                double Salhm2 = h2 * 9.15 + ((h2 - 160) * 11.50);                
                double ISSm2 = Salhm2 * 0.0535;
                double AFPm2 = Salhm2 * 0.0688;
                double RENTAm2 = Salhm2 * 0.10;
                double descm2 = ISSm2 + AFPm2 + RENTAm2;
                double SalLiquidm2 = Salhm2 - descm2;
                if (title == 1)
                {
                    double Salwbonm2 = SalLiquidm2 / 0.10;
                    Console.WriteLine("nombre del empleado:" + name2 + "\nDescuento del ISS:" + ISSm2 + "\nDescuento del AFP:" + AFPm2 + "\nDescuento De Renta:" + RENTAm2 + "\nSueldo Liquido:" + Salwbonm2);
                    Console.WriteLine("");
                }
                else if (title == 2)
                {
                    double Salwbonm2 = SalLiquidm2 / 0.05;
                    Console.WriteLine("nombre del empleado:" + name2 + "\nDescuento del ISS:" + ISSm2 + "\nDescuento del AFP:" + AFPm2 + "\nDescuento De Renta:" + RENTAm2 + "\nSueldo Liquido:" + Salwbonm2);
                    Console.WriteLine("");
                }
                else if (title == 3)
                {
                    double Salwbonm2 = SalLiquidm2 / 0.03;
                    Console.WriteLine("nombre del empleado:" + name2 + "\nDescuento del ISS:" + ISSm2 + "\nDescuento del AFP:" + AFPm2 + "\nDescuento De Renta:" + RENTAm2 + "\nSueldo Liquido:" + Salwbonm2);
                    Console.WriteLine("");
                }
                else if (title == 4)
                {
                    double Salwbonm2 = SalLiquidm2 / 0.02;
                    Console.WriteLine("nombre del empleado:" + name2 + "\nDescuento del ISS:" + ISSm2 + "\nDescuento del AFP:" + AFPm2 + "\nDescuento De Renta:" + RENTAm2 + "\nSueldo Liquido:" + Salwbonm2);
                    Console.WriteLine("");
                }
            }

            if (h3 <= 160)
            {
                double Salhn3 = h3 * 9.75;
                double ISSn3 = Salhn3 * 0.0535;
                double AFPn3 = Salhn3 * 0.0688;
                double RENTAn3 = Salhn3 * 0.10;
                double descn3 = ISSn3 + AFPn3 + RENTAn3;
                double SalLiquidn3 = Salhn3-descn3;
                if (title == 1)
                {
                    double Salwbonn3 = SalLiquidn3 / 0.10;
                    Console.WriteLine("nombre del empleado:" + name3 + "\nDescuento del ISS:" + ISSn3 + "\nDescuento del AFP:" + AFPn3 + "\nDescuento De Renta:" + RENTAn3 + "\nSueldo Liquido:" + Salwbonn3);
                    Console.WriteLine("");
                }
                else if (title == 2)
                {
                    double Salwbonn3 = SalLiquidn3 / 0.05;
                    Console.WriteLine("nombre del empleado:" + name3 + "\nDescuento del ISS:" + ISSn3 + "\nDescuento del AFP:" + AFPn3 + "\nDescuento De Renta:" + RENTAn3 + "\nSueldo Liquido:" + Salwbonn3);
                    Console.WriteLine("");
                }
                else if (title == 3)
                {
                    double Salwbonn3 = SalLiquidn3 / 0.03;
                    Console.WriteLine("nombre del empleado:" + name3 + "\nDescuento del ISS:" + ISSn3 + "\nDescuento del AFP:" + AFPn3 + "\nDescuento De Renta:" + RENTAn3 + "\nSueldo Liquido:" + Salwbonn3);
                    Console.WriteLine("");
                }
                else if (title == 4)
                {
                    double Salwbonn3 = SalLiquidn3 / 0.02;
                    Console.WriteLine("nombre del empleado:" + name3 + "\nDescuento del ISS:" + ISSn3 + "\nDescuento del AFP:" + AFPn3 + "\nDescuento De Renta:" + RENTAn3 + "\nSueldo Liquido:" + Salwbonn3);
                    Console.WriteLine("");
                }
            }
            else if (h3 > 160)
            {
                double Salhm3 = h3 * 9.15 + ((h3 - 160) * 11.50);
                double ISSm3 = Salhm3 * 0.0535;
                double AFPm3 = Salhm3 * 0.0688;
                double RENTAm3 = Salhm3 * 0.10;
                double descm3 = ISSm3 + AFPm3 + RENTAm3;
                double SalLiquidm2 = Salhm3 - descm3;
                if (title == 1)
                {
                    double Salwbonm3 = SalLiquidm2 / 0.10;
                    Console.WriteLine("nombre del empleado:" + name3 + "\nDescuento del ISS:" + ISSm3 + "\nDescuento del AFP:" + AFPm3 + "\nDescuento De Renta:" + RENTAm3 + "\nSueldo Liquido:" + Salwbonm3);
                    Console.WriteLine("");
                }
                else if (title == 2)
                {
                    double Salwbonm3 = SalLiquidm2 / 0.05;
                    Console.WriteLine("nombre del empleado:" + name3 + "\nDescuento del ISS:" + ISSm3 + "\nDescuento del AFP:" + AFPm3 + "\nDescuento De Renta:" + RENTAm3 + "\nSueldo Liquido:" + Salwbonm3);
                    Console.WriteLine("");
                }
                else if (title == 3)
                {
                    double Salwbonm3 = SalLiquidm2 / 0.03;
                    Console.WriteLine("nombre del empleado:" + name3 + "\nDescuento del ISS:" + ISSm3 + "\nDescuento del AFP:" + AFPm3 + "\nDescuento De Renta:" + RENTAm3 + "\nSueldo Liquido:" + Salwbonm3);
                    Console.WriteLine("");
                }
                else if (title == 4)
                {
                    double Salwbonm3 = SalLiquidm2 / 0.02;
                    Console.WriteLine("nombre del empleado:" + name3 + "\nDescuento del ISS:" + ISSm3 + "\nDescuento del AFP:" + AFPm3 + "\nDescuento De Renta:" + RENTAm3 + "\nSueldo Liquido:" + Salwbonm3);
                    Console.WriteLine("");
                }

                
            }
            


            if (title == 1 && title2 == 2 && title3 == 3)
            {
                Console.WriteLine("no reciben bono");
                if (h <= 160)
                {
                    double Salhn = h * 9.75;

                    double ISSn1 = Salhn * 0.0535;
                    double AFPn1 = Salhn * 0.0688;
                    double RENTAn1 = Salhn * 0.10;
                    double descn1 = ISSn1 + AFPn1 + RENTAn1;
                    double SalLiquidn1 = Salhn - descn1;
                    Console.WriteLine("nombre del empleado:" + name + "\nDescuento del ISS:" + ISSn1 + "\nDescuento del AFP:" + AFPn1 + "\nDescuento De Renta:" + RENTAn1 + "\nSueldo Liquido:" + SalLiquidn1);
                    Console.WriteLine("");


                }
                else if (h > 160)
                {
                    double Salhm = h * 9.15 + ((h - 160) * 11.50);
                    double ISSm1 = Salhm * 0.0535;
                    double AFPm1 = Salhm * 0.0688;
                    double RENTAm1 = Salhm * 0.10;
                    double descm1 = ISSm1 + AFPm1 + RENTAm1;
                    double SalLiquidm1 = Salhm - descm1;
                    Console.WriteLine("nombre del empleado:" + name + "\nDescuento del ISS:" + ISSm1 + "\nDescuento del AFP:" + AFPm1 + "\nDescuento De Renta:" + RENTAm1 + "\nSueldo Liquido:" + SalLiquidm1);
                    Console.WriteLine("");
                }

                if (h2 <= 160)
                {
                    double Salhn2 = h2 * 9.75;
                    double ISSn2 = Salhn2 * 0.0535;
                    double AFPn2 = Salhn2 * 0.0688;
                    double RENTAn2 = Salhn2 * 0.10;
                    double descn2 = ISSn2 + AFPn2 + RENTAn2;
                    double SalLiquidn2 = Salhn2 - descn2;
                    Console.WriteLine("nombre del empleado:" + name2 + "\nDescuento del ISS:" + ISSn2 + "\nDescuento del AFP:" + AFPn2 + "\nDescuento De Renta:" + RENTAn2 + "\nSueldo Liquido:" + SalLiquidn2);
                    Console.WriteLine("");
                }
                else if (h2 > 160)
                {
                    double Salhm2 = h2 * 9.15 + ((h2 - 160) * 11.50);
                    double ISSm2 = Salhm2 * 0.0535;
                    double AFPm2 = Salhm2 * 0.0688;
                    double RENTAm2 = Salhm2 * 0.10;
                    double descm2 = ISSm2 + AFPm2 + RENTAm2;
                    double SalLiquidm2 = Salhm2 - descm2;
                    Console.WriteLine("nombre del empleado:" + name2 + "\nDescuento del ISS:" + ISSm2 + "\nDescuento del AFP:" + AFPm2 + "\nDescuento De Renta:" + RENTAm2 + "\nSueldo Liquido:" + SalLiquidm2);
                    Console.WriteLine("");
                }

                if (h3 <= 160)
                {
                    double Salhn3 = h3 * 9.75;
                    double ISSn3 = Salhn3 * 0.0535;
                    double AFPn3 = Salhn3 * 0.0688;
                    double RENTAn3 = Salhn3 * 0.10;
                    double descn3 = ISSn3 + AFPn3 + RENTAn3;
                    double SalLiquidn3 = Salhn3 - descn3;
                    Console.WriteLine("nombre del empleado:" + name3 + "\nDescuento del ISS:" + ISSn3 + "\nDescuento del AFP:" + AFPn3 + "\nDescuento De Renta:" + RENTAn3 + "\nSueldo Liquido:" + SalLiquidn3);
                    Console.WriteLine("");
                }
                else if (h3 > 160)
                {
                    double Salhm3 = h3 * 9.15 + ((h3 - 160) * 11.50);
                    double ISSm3 = Salhm3 * 0.0535;
                    double AFPm3 = Salhm3 * 0.0688;
                    double RENTAm3 = Salhm3 * 0.10;
                    double descm3 = ISSm3 + AFPm3 + RENTAm3;
                    double SalLiquidm3 = Salhm3 - descm3;
                    Console.WriteLine("nombre del empleado:" + name3 + "\nDescuento del ISS:" + ISSm3 + "\nDescuento del AFP:" + AFPm3 + "\nDescuento De Renta:" + RENTAm3 + "\nSueldo Liquido:" + SalLiquidm3);
                    Console.WriteLine("");
                }

            }


        }
    }
}
