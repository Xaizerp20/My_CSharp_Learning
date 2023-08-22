using System;

namespace TASK_MANAGER
{
    internal class Program
    {

        public static string taskName = null!;
        public static string taskDescription = null!;
        public static Priority taskPriority = Priority.Low;
        public static string taskDueDate = null!;
        public static Dictionary<int, string> PendingTasks = new Dictionary<int, string>();
        public static Dictionary<int, string> CompletedTasks = new Dictionary<int, string>();

        static void Main(string[] args)
        {




            while (true)
            {
                Console.WriteLine("\nTask Manager");
                Console.WriteLine("------------");

                Console.WriteLine("1. Add Task \n2. Mask Task as Completed \n3. View pending Tasks \n4. View Completed Tasks \n5. Exit");


                Console.Write("\nSelect an Option: ");
                int choice = Convert.ToInt32(Console.ReadLine());


                if (choice == 1)
                {
                    CreateTask();

                }
                else if (choice == 2)
                {
                    CompleteTask();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Pending Tasks: ");
                    foreach (KeyValuePair<int, string> task in PendingTasks)
                    {
                        Console.WriteLine($"    {task.Key}. {task.Value}");
                    }
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Completed Tasks: ");
                    foreach (KeyValuePair<int, string> task in CompletedTasks)
                    {
                        Console.WriteLine($"    {task.Key}. {task.Value}");
                    }
                }
                else if (choice == 5)
                {
                    break;
                }

                Thread.Sleep(2000);
            }





        }

        //Enum that contains the priority of the Task
        public enum Priority
        {
            Low,
            Medium,
            High
        }

        public enum status
        {
            pending,
            Completed
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

            int QuantityTasks = PendingTasks.Count();

            //Console.Write("Enter Task Name: ");
            //taskName = Console.ReadLine();

            Console.Write("Enter Task Description: ");
            taskDescription = Console.ReadLine();

            Console.Write("Select Task Priority: ");
            taskPriority = SelectorPriority(Convert.ToInt16(Console.ReadLine()));

            Console.Write("Enter due date (DD-MM-YYYY): ");
            taskDueDate = Console.ReadLine();


            PendingTasks.Add(QuantityTasks + 1, $"[{taskPriority}] {taskDescription} ({taskDueDate}) "); //add task to the list

            Console.WriteLine("\nTask added successfully!\n");

        }

        public static void CompleteTask()
        {

            int QuantityTasks = CompletedTasks.Count();

            foreach (KeyValuePair<int, string> task in PendingTasks)
            {
                Console.WriteLine($"{task.Key}. {task.Value}");
            }

            Console.Write("Enter the number of the task you want to mark as completed: ");
            int taskId = Convert.ToInt32(Console.ReadLine());

            //Get Task number using Linq Remove Task of Pending list and add Task to Completed list
            KeyValuePair<int, string> taskPending = PendingTasks.FirstOrDefault(task => task.Key == taskId); //get task using linq
            PendingTasks.Remove(taskId); //remove task from pending tasks

            string ReformatTask = taskPending.Value.Split("(")[0] + "(Completed)";

            CompletedTasks.Add(QuantityTasks + 1, ReformatTask); //add task to completed tasks


            Console.WriteLine("\nTask marked as completed!");
        }

    }
}