using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArknightsAssistant
{
    internal class About
    {
        public void Run()
        {
            WriteLine("Hello, this is About\nPress [ESC] to navigate to an upper level");

            ConsoleKey keyPressed = ConsoleKey.A;
            while (keyPressed != ConsoleKey.Escape)
            {
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
            }
        }
    }
}
