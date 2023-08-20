using System;

namespace FIBONACCI_CALCULATOR // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int previous = 0;
            int fibNumber = 1;
            int number = 0;
            int actual = 0;



            Console.WriteLine("Insert Numbers Quantity: ");
            int n = Convert.ToInt32(Console.ReadLine()); //get number serie 


        


            for(int i = 0; i < n; i++)
            {
                
                //check if its firts iteration   
                if(number  == 0){

                    Console.WriteLine(number);

                    number = previous + 1; 

                    Console.WriteLine(number);

                    actual = number;
                    previous++;
                }

                else{
                    
                    number = previous + actual;
                    Console.WriteLine(number);


                    previous = actual; //get previous number
                    actual = number; //assing actual number for next addition

                    

                }

            }
                

        }

    }
}
