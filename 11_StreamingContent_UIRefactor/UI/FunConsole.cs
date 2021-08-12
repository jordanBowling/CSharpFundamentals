﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_StreamingContent_UIRefactor.UI
{
    public class FunConsole : IConsole
    {
        public void Clear()
        {
            Console.Clear();

            Random randy = new Random();
            int colorIndex = randy.Next(0, 15);

            Console.BackgroundColor = (ConsoleColor)colorIndex;
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            string input = Console.ReadLine();
            Console.WriteLine("Umm...");
            Thread.Sleep(100);
            Console.WriteLine("Okay..");
            Thread.Sleep(100);
            return input;
        }

        public void Write(string s)
        {
            Console.Write(s.ToUpper());
        }

        public void WriteLine(string s)
        {
            Random randy = new Random();
            int colorIndex = randy.Next(0, 16);
            Console.ForegroundColor = (ConsoleColor)colorIndex;
            bool capitalize = false;
            foreach (char letter in s)
            {
                if (capitalize)
                {   
                    //              chained method calls vvv
                    Console.Write(letter.ToString().ToUpper());
                    capitalize = false;
                }
                else
                {
                    Console.Write(char.ToLower(letter));  //another way of doing a similar thing as the IF
                    capitalize = true;
                }

            }
        }

        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }
    }
}
