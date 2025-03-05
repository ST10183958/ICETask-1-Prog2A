using System;



namespace Program

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter your name:");

            String name = Console.ReadLine();



            Console.WriteLine("Enter your student number:");

            String StudentNumber = Console.ReadLine();



            Console.WriteLine("Enter your course:");

            String Course = Console.ReadLine();



            Console.Write("Enter the number of modules your doing:");

            String NumbModules = Console.ReadLine();



            Console.WriteLine("Your name is " + name + " Your student number is " + StudentNumber + $"Your course is {Course} and your doing {NumbModules} modules");

        }

    }

}