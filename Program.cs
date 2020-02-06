using System;

namespace Deliverable3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {             
            // Ask for user to input his/her name
            Console.WriteLine("Please enter your name:");
            string Username;
            Name();
            
        }

        private static void Name()
        {

            string Username = Console.ReadLine(); // collect user input
            if (System.Text.RegularExpressions.Regex.IsMatch(Username, "[a-zA-Z]" + " " + "[a-zA-Z]+$")) // test if user entered string or not
            {
                // display message to user
                Console.WriteLine("Hello" + " " + Username + "!");

            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(Username, @"^[a-zA-Z]+$"))
            {
                // display message to user
                Console.WriteLine("Hello" + " " + Username + "!");

            }
            else
            {
                // display error message to user
                Console.WriteLine("Please only enter alphabetical letters.");
                Console.WriteLine("Please enter your name and try again.");
            }
        }

    }
}
