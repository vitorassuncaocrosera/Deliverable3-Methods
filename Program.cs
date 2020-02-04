using System;

namespace Deliverable3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // try catch to prevent coding erros
            try
            {
                // Ask for user input
                Console.WriteLine("Please enter your name:");
                string userName = HelloName();

                // Show message to user input
                Console.WriteLine("Hello " + userName + "!");

            }

            catch
            {   //If error in the code, the follow message will appear:
                Console.WriteLine("An error was present in the code. Please try again. ");
            }
        }


        private static string HelloName()
        {
            string UserName = Console.ReadLine();
            return UserName;
        }
        }

    } // End of Max_Heart_Rate
    
