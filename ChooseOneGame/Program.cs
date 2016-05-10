using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChooseOneGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you prefer what is behind door 1, 2, or 3?");
            string userValue = Console.ReadLine();
            //this gets the value from the user

            string message = get_message(userValue);
            //this sends the message to the get_message module and then returns the message value from
            //the module to be out put by the main.
            Console.WriteLine(message);
            //this outputs the message variable to the screen
            Console.ReadLine();
            //this pauses the program to wait for you to press a key to return to the ide
        }

        public static string get_message(string userValue)
        {
            string message = "";
            if (userValue == "1")
            {
                message = "You won a new car";
            }
            else if (userValue == "2")
            {
                message = "You won a new boat";
            }
            else if (userValue == "3")
            {
                message = "You won a new cat";
            }
            else
            {
                Console.WriteLine("Sorry we didnt understand. You lose! ");
                Console.ReadLine();
            }
            return message;
        }
    }
}
