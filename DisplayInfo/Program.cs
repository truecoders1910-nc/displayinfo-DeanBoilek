using System;

namespace DisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine ();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("What's your favorite number?");
            string favNum = Console.ReadLine();
            Console.Write("Name your favorite animal: ");
            string favAnimal = Console.ReadLine();
            if (Convert.ToInt32(favNum) > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (Convert.ToInt32(favNum) < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine($"Your name is {firstName} {lastName}, your favorite number is {favNum}, and your favorite animal is a {favAnimal}");
            Console.ReadLine();

            
            

         




            // Get first and last name from user input
            // Get their favorite number
            // Get their favorite animal

            // Once you have gotten all their info and stored it,
            // display it back to them.

            // If their favorite number is greater than 10, display it in green.
            // If their favorite number is less than 5, display it in red.
        }
    }
}
