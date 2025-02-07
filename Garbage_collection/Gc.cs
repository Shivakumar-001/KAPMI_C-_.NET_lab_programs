using System;

public class Demo
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n1. Number of Generations");
            Console.WriteLine("2. Generation number of target objects");
            Console.WriteLine("3. Number of bytes Allocated");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            Demo obj = new Demo();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Number of Generations: " + GC.MaxGeneration);
                    break;
                case 2:
                    Console.WriteLine("Generation number of target objects: " + GC.GetGeneration(obj));
                    break;
                case 3: // Fixed duplicate case 2
                    Console.WriteLine("Number of bytes Allocated: " + GC.GetTotalMemory(true));
                    break;
                case 4:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
}


