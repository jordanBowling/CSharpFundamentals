using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            //While loops keep going WHILE something is true

            int total = 1;
            while (total != 50) // expression that is either true or false
            {
                Console.WriteLine(total);
                // total = total + 1;
                // total += 1;
                // total++;
            }
            total = 0;
            while (true)
            {
                if (total ==10)
                {
                    Console.WriteLine("Goal reached!");
                    // break out of this loop
                    //intellisense tells us which loop it will break by highlighting it.                                                                                           
                    break;
                }
                total++;
            }

            Random rand = new Random();
            int someNumber;
            bool keepLooping = true;

            while (keepLooping)
            {
                someNumber = rand.Next(0, 20); //anywhere between 0 and 19 // can be different in other languages
                if (someNumber == 0 || someNumber == 13)
                {
                    //skip to the next loop
                    continue;
                }
                
                Console.WriteLine(someNumber);

                if (someNumber == 15)
                {
                    keepLooping = false;
                }


            }

        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 26;
            // 1 - starting point, do this once at the very beginning
            // 2 - Loop condition, keep looping if this condition == true
            // 3 - Do this after each loop
            // 4 - The code executed every loop
            //    1            2              3
            for (int i = 0; i < studentCount; i++)
            {
                // 4
                Console.WriteLine(i);
            }

            string[] students = { "kristen", "Doug", "Jordan", "Mitch", "David", "Dinara" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to class, {students[i]}");
            }
            
            // 1 - declare the type
            // 2 - name the item
            // 3 - "in" keyword
            // 4 - the list
            //         1        2   3   4
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            string myName = "JordanThomasBowling";
            foreach (char letter in myName)
            {
                if (letter != 'o')
                { 
                // These are the same
                // Console.Write(letter + "\n");
                Console.WriteLine(letter);
                }
            }

        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello!");
                iterator++;
            } while (iterator < 5);
        }

        [TestMethod]
        public void LoopsChallenge()
        {
            string bigWord = "Supercalifragilisticexpialidocious";
            foreach (char each in bigWord)
            {
                Console.WriteLine(each);
            }

            foreach (char each in bigWord)
            {
                if (each == 'i')
                {
                    
                    Console.WriteLine(each);
                }
                // should have been else if
                if (each != 'i')
                {
                    Console.WriteLine("Not an i");
                }
                if (each == 'l')
                {
                    Console.WriteLine(each);
                }
            }

            Console.WriteLine(bigWord.Length);
        }
    }
}
