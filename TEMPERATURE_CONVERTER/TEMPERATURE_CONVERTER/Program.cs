using System;

namespace TEMPERATURE_CONVERTER // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            float Celcius = 0;
            float Fahrenheit = 0;
            int choice = 0;

            Console.WriteLine("\nSelecte what you want to Convert\n");

            Console.WriteLine("\t1. Fahrenheit to Celcius");
            Console.WriteLine("\t2. Celcius to Fahrenheit");

            Console.Write("\nEnter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {
                Console.Write("Enter Celcius: ");
                Celcius = Convert.ToSingle(Console.ReadLine());
                Fahrenheit = (Celcius * 9/5) + 32;

                Console.WriteLine($"\n{Celcius} degrees Celcius is equal to {Fahrenheit} degrees Fahrenheit");

            }
            else if (choice == 2)
            {
                Console.Write("Enter Fahrenheit: ");
                Fahrenheit = Convert.ToSingle(Console.ReadLine());
                Celcius = (Fahrenheit - 32) * 5 / 9;

                Console.WriteLine($"\n{Fahrenheit} degrees Fahrenheit is equal to {Celcius} degrees Celcius");
            }
            else
            {
                Console.WriteLine("\nInvalid choice");
            }


        }
    }
}