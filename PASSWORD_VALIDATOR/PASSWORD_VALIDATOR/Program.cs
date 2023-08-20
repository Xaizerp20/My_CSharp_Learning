using System;

using System.Text.RegularExpressions;


namespace PASSWORD_VALIDATOR // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool CheckLength = false;
            bool CheckNumbers = false;
            bool CheckUpper = false;
            bool CheckLower = false;
            bool CheckSpecial = false;


            string numberPatterns = @"[0-9]";
            string upperPattern = @"[A-Z]";
            string lowerPattern = @"[a-z]";
            string specialPattern = @"[^\w\s]";

            Regex regexNumber = new Regex(numberPatterns);
            Regex regexUpper = new Regex(upperPattern);
            Regex regexLower = new Regex(lowerPattern);
            Regex regexSpecial = new Regex(specialPattern);

            Console.WriteLine("Requeriments: ");
            Console.WriteLine("\t* At least 8 characters");
            Console.WriteLine("\t* At least 1 number");
            Console.WriteLine("\t* At least 1 lowercase letter");
            Console.WriteLine("\t* At least 1 uppercase letter");
            Console.WriteLine("\t* At least 1 special character");
            Console.WriteLine("Write password: ");


            string? password = Console.ReadLine(); //write password 
            






            //check if password is null 
            if(password != null){
                
                //check first requeriment
                if(password.Length >= 8){
                    
                    CheckLength = true;
                    
                    //check second requeriment using regular expression
                    if(regexNumber.IsMatch(password)){
                        
                        CheckNumbers = true;

                        //check third requeriment using regular expression
                        if(regexUpper.IsMatch(password)){

                            CheckUpper = true;

                            //check fourth requeriment using regular expression
                            if(regexLower.IsMatch(password)){
                                
                                CheckLower = true;


                                if(regexSpecial.IsMatch(password)){

                                    CheckSpecial = true;
                                }

                                else{
                                    
                                    Console.WriteLine("Password must contain at least 1 special character");
                                }

                            }
                            else{
                                Console.WriteLine("Password must contain at least 1 lowercase letter");
                            }

                        }

                        else{
                            
                            Console.WriteLine("Password must contain at least 1 uppercase letter");
                        }

                    }

                    else{
                        Console.WriteLine("Password must contain at least 1 number");
                    }

                }

                else{
                    Console.WriteLine("Password must have at least 8 characters");
                    return;
                }
            }

            else{
                Console.WriteLine("Password cannot be null");
                return;
            }


            if(CheckLength && CheckNumbers && CheckUpper && CheckLower && CheckSpecial){
                Console.WriteLine("Password is valid");
            }
            else{
                Console.WriteLine("Password is not valid");
            }

        }
    }
}