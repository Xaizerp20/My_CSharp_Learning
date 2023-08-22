using System;

namespace TASK_MANAGER
{
    internal class Program
    {

        public static string taskName = null!;
        public static string taskDescription = null!;
        public static Priority taskPriority = Priority.Low;
        public static string taskDueDate = null!;
        public static List<string> ListTask = new List<string>();

        static void Main(string[] args)
        {




            while (true)
            {
                Console.WriteLine("Task Manager");
                Console.WriteLine("------------");

                Console.WriteLine("1. Add Task \n2. Mask Task as Completed \n3. View pending Tasks \n4. View Completed Tasks \n5. Exit");


                Console.Write("\nSelect an Option: ");
                int choice = Convert.ToInt32(Console.ReadLine());


                if (choice == 1)
                {
                    CreateTask();
                }
                else if (choice == 3)
                {
                    int i = 1;
                    foreach (string task in ListTask)
                    {
                        Console.WriteLine($"{i++}. {task}");
                    }
                }
            }





        }

        //Enum that contains the priority of the Task
        public enum Priority
        {
            Low,
            Medium,
            High
        }

        //Method to select the priority
        public static Priority SelectorPriority(int option)
        {
            switch (option)
            {
                case 1:
                    return Priority.Low;
                case 2:
                    return Priority.Medium;
                case 3:
                    return Priority.High;
                default:
                    return Priority.Low; //TODO: LAUNCH EXCEPTION
            }
        }

        //Metho to Create Task and Add to List of Task
        public static void CreateTask()
        {
            //Console.Write("Enter Task Name: ");
            //taskName = Console.ReadLine();

            Console.Write("Enter Task Description: ");
            taskDescription = Console.ReadLine();

            Console.Write("Select Task Priority: ");
            taskPriority = SelectorPriority(Convert.ToInt16(Console.ReadLine()));

            Console.Write("Enter due date (DD-MM-YYYY):");
            taskDueDate = Console.ReadLine();

            ListTask.Add($"[{taskPriority}] {taskDescription} ({taskDueDate}) ");

            Console.WriteLine("Task added successfully!");

        }
    }
}