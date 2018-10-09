using System;

namespace About_Me_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, please take a quiz about me!");

            Console.WriteLine("What state am I from?");
            string questionOne = Console.ReadLine();

            Console.WriteLine("Guess the day of my birth");
            int questionTwo = int.Parse(Console.ReadLine());



            Console.WriteLine($"You answered {questionOne}. Your answer is: {QuestionOne(questionOne)}");
            QuestionTwo(questionTwo);



        }
        //Question 1: Method to check users input with an if statement
        static string QuestionOne(string input)
        {
            if (input == "CO" || input == "Colorado")
            {
                return "Correct";
            }
            else
                return "Incorrect";
        }

        //Question 2: Method to check if user's integar input is correct
        static int QuestionTwo(int numInput)
        {
            if (numInput == 29)
            {
                Console.WriteLine("Your answer is correct.");
                return 29;
            }
            else
            {
                Console.WriteLine($"That is incorrect. You are {29-numInput} days off");
                return 29-numInput;
            }
        }
    }
}
