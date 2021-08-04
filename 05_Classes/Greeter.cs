using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Greeter
    {   
        // 1 Access Modifier => Visibility in the program
        // 2 Return type => What the method gives back
        // 3(4) Method signature => The method name and the Parameters
        // 4 Parameters => What we need to pass to the method
        // 5 Statements or body => code executed (Also called method body)
        //1     2      3      4
        public void SayHello(string name)
        {
            // 5
            Console.WriteLine($"Hello {name}!");
        }

        // Overload, same name different signature
        public void SayHello()
        {
            Console.WriteLine("Hello Stranger!");
        }

        Random _randy = new Random();

        public void RandomGreeting()
        {
            string[] availableGreetings = new string[] {"hello", "Hi", "Greetings", "Sup", "Good Afternoon", "howdy", "whats poppin g?"};

            int randomNumber = _randy.Next(0, availableGreetings.Length);
            string randomGreeting = availableGreetings[randomNumber];
            Console.WriteLine(randomGreeting);
        }
    }
}
