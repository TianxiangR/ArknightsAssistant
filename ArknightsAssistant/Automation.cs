using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArknightsAssistant
{
    internal class Automation
    {
        public void Run()
        {
            WriteLine("Hello, this is Automation\nPress [ESC] to navigate to an upper level");

            ConsoleKey keyPressed = ConsoleKey.A;
            while (keyPressed != ConsoleKey.Escape)
            {
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
            }
        }
    }
}
