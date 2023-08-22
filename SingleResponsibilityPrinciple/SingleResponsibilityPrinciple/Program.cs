using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();
            Console.WriteLine("Welcome to my application");
            Person user = new Person();

            Console.Write("What is your first name: ");
            user.FirstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            user.LastName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("You did not give us a valid first name!");
                StandardMessages.EndApplication();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("You did not give us a valid last name!");
                StandardMessages.EndApplication();
                return;
            }

            //Create a username for the person
            Console.WriteLine($"Your username is { user.FirstName.Substring(0, 1)}{user.LastName}");
            StandardMessages.EndApplication();
        }
    }
}
