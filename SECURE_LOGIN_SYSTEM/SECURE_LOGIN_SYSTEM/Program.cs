/* In this project, you will develop a user registration and access system. 
    Users will be able to register with a username and password, 
    and then log in to the system using their credentials. 
    Passwords will be securely stored using encryption techniques. */


//TODO: APPLY SALTING TO PASSWORD
//TODO: ADD REQUERIMENTS FOR PASSWORD
//TODO: MASKING PASSWORD IN CONSOLE

namespace MyApp
{
    using System;
    using BCrypt.Net;

    public class SECURE_LOGIN_SYSTEM
    {

        public static Dictionary<int, User> UsersList = new Dictionary<int, User>();


        static void Main(string[] args)
        {


            while (true)
            {


                Console.WriteLine("\nUser registration and Login system");

                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                Console.Write("Select an Option: ");


                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        RegisterUser(); //register
                        break;

                    case 2:
                        LoginUser(); //login 
                        break;
                    
                    case 3:
                        break; //exit

                    default: //TODO: IMPLEMENT EXCEPTION
                        break;
                }

            }


        }

        public static void RegisterUser()
        {
            Console.Write("Enter User Name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter Password: ");
            string passwordHash = BCrypt.HashPassword(Console.ReadLine()); //Encrypt password

            if (userName != null && passwordHash != null)
            {
                //add user to list of users
                UsersList.Add(UsersList.Count() + 1, new User()
                {
                    UserName = userName,
                    PasswordHash = passwordHash
                }
                );


            }


        }

        public static void LoginUser()
        {
            string? userName = "";
            string? password = "";


            //insert username and password 
            Console.Write("Enter your User Name: ");
            userName = Console.ReadLine();
            Console.Write("Enter your Password: ");
            password = Console.ReadLine();

            User userLogin = UsersList.FirstOrDefault(x => x.Value.UserName == userName).Value; //search user into list
            
            //check if user exists
            if (userLogin != null)
            {
                bool checkPassword = BCrypt.Verify(password, userLogin.PasswordHash); //checking password hashing

                //Checking the password and Username
                if (userLogin.UserName == userName && checkPassword)
                {
                    Console.WriteLine($"\nLogin Successful, Welcome {userLogin.UserName}");
                }
                else
                {
                    Console.WriteLine("\nIncorrect Password");
                }

            }
            else
            {
                Console.WriteLine("\nUser not found");
            }


        }
    }


    public class User
    {
        private string _username = null!;
        private string _passwordHash = null!;



        public string UserName
        {
            get => _username;
            set => _username = value;
        }

        public string PasswordHash
        {
            get => _passwordHash;
            set => _passwordHash = value;
        }
    }
}

