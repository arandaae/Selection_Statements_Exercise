using System;

namespace Selection_Statements_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite number.");
            Console.WriteLine();

            int favNumber = 7;

            int userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Guess is too low.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Guess is to high.");
            }
            else
            {
                Console.WriteLine("You are correct!");
            }

            Console.Clear();

            SchoolSubject();
            static void SchoolSubject()
            {
                Console.WriteLine("What is your favorite school subject");
                Console.WriteLine("Math, History, English, Biology, Chemistry");
                string subject = Console.ReadLine();

                switch (subject.ToLower())
                {
                    case "Math":
                        Console.WriteLine("Math is your favorite subject!");
                        break;
                    case "History":
                        Console.WriteLine("History is your favorite subject!");
                        break;
                    case "English":
                        Console.WriteLine("English is your favorite subject!");
                        break;
                    case "Biology":
                        Console.WriteLine("Biology is your favorite subject!");
                        break;
                    case "Chemistry":
                        Console.WriteLine("Chemistry is your favorite subject!");
                        break;
                    default:
                        Console.WriteLine("That subject is not included here.");
                        break;
                }
                Console.WriteLine();
            }

        }
    }
}
