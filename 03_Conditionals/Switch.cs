using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void TestMethod1()
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello!");
                    break;
                case 2:
                    Console.WriteLine("Hello2You");
                    break;
                case 3:
                case 5:
                case 7:
                case 9:
                    Console.WriteLine("Hi, you're odd");
                    break;
                default: // triggers if no cases are met
                    Console.WriteLine("Default reply");
                    break;

            }

            // If Version
            if (input == 1)
            {
                Console.WriteLine("Hello1");
            }
            else if (input == 2)
            {
                Console.WriteLine("hello2you");
            }
            else if (input % 2 != 0 )
            {
                Console.WriteLine("You're odd");
            }
        }
    }
}
