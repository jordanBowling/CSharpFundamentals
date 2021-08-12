using _09_StreamingContent_Console.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console
{
    class Program
    {   
        // args = array of options or commands you can type after the name of your program
        static void Main(string[] args)
        {
            // This is where you setup the app, deal with input, etc
            ProgramUI ui = new ProgramUI();
            ui.Run();

            // Not static because we need to use a field
            // ProgramUI.Run()


        }
    }
}
