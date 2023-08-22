using System;
using System.Diagnostics;

namespace MathTrack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int op = 0;
            double N1 = 0;
            double N2 = 0;
            double result = 0;



            while (true)
            {

                /****** MENU *******/
                Console.WriteLine("**** Math Track ****");

                Console.WriteLine(" 1. Addition \n 2. Substraction \n 3. Multiplication \n 4. Division \n 5. History \n 6. Exit\n");

                Console.Write("Select Option: ");
                op = int.Parse(Console.ReadLine());


                //if select option 6 finish program
                if(op == 6){
                    return;
                }

                Console.Write("Enter the first Number: ");
                N1 = Convert.ToInt32(Console.ReadLine());


                Console.Write("Enter the first Number: ");
                N2 = Convert.ToInt32(Console.ReadLine());

                result = WorkOperation(op, N1, N2); //execute operation
                Console.Write($"Result: {result}\n\n");
            }


            double WorkOperation(int operation, double N1, double N2)
            {

                double result;

                switch (operation)
                {

                    case 1:
                        result = N1 + N2;
                        break;

                    case 2:
                        result = N1 - N2;
                        break;

                    case 3:
                        result = N1 * N2;
                        break;

                    case 4:
                        result = N1 / N2;
                        break;

                    default:
                        throw new Exception("");

                }

                return result;
            }


        }
    }
}