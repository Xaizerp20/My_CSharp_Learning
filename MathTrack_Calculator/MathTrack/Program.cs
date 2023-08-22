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
            
            List<string> historical = new List<string>();

            while (true)
            {

                /****** MENU *******/
                Console.WriteLine("\n********** Math Track **********");
                Console.WriteLine("--------------------------------");

                Console.WriteLine(" 1. Addition \n 2. Substraction \n 3. Multiplication \n 4. Division \n 5. History \n 6. Exit\n");

                Console.Write("Select Option: ");

                
                try
                {
                    op = int.Parse(Console.ReadLine()); //get option value
                }
                catch(FormatException)
                {
                    Console.WriteLine("Option incorrect, try again");
                    continue;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }



                //if select option 6 finish program
                if (op == 6)
                {
                    return;
                }

                //option 5 show historical
                else if (op == 5)
                {  

                    Console.WriteLine("***** HISTORICAL *******");

                    foreach (string s in historical){
                        Console.WriteLine(s);
                    }

                    continue;
                }
                else
                {
                
                    //GET NUMBERS AND EXCUTE OPERATION

                    Console.Write("Enter the first Number: ");
                    N1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the first Number: ");
                    N2 = Convert.ToInt32(Console.ReadLine());


                    try
                    {
                        result = WorkOperation(op, N1, N2); //execute operation
                         Console.Write($"Result: {result}\n\n");
                    }
                    catch
                    {
                            Console.WriteLine("Invalid Selection, try again");
                            
                    }
                    
                   
                }




            }


            double WorkOperation(int operation, double N1, double N2)
            {

                double result;


                switch (operation)
                {

                    case 1:
                        result = N1 + N2;
                        historical.Add($"{N1} + {N2} = {result}");
                        break;

                    case 2:
                        result = N1 - N2;
                        historical.Add($"{N1} - {N2} = {result}");
                        break;

                    case 3:
                        result = N1 * N2;
                        historical.Add($"{N1} x {N2} = {result}");
                        break;

                    case 4:

                        try
                        {
                            result = N1 / N2;
                            historical.Add($"{N1} / {N2} = {result}");
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            result = 0;
                        }
                        
                        break;

                    default:
                        throw new Exception("Invalid Operation Selection, try again");

                }

                return result;
            }


        }
    }
}