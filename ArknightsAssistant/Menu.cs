using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArknightsAssistant
{
    internal class Menu
    {
        private string Prompt;
        private string[] Options;
        private int selectedIndex;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            selectedIndex = 0;
        }

        private void Display()
        {
            // Render prompt
            WriteLine(Prompt);
            WriteLine();

            // Render options
            for (int i = 0; i < Options.Length; i++)
            {
                string toBeRendered = "";
                
                // Change color
                if (i == selectedIndex)
                {
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                    toBeRendered = $"<< {Options[i]} >>";
                } else
                {
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                    toBeRendered = $"<< {Options[i]} >>";
                }

                WriteLine(toBeRendered);
            }
            ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;

            do
            {
                Clear();
                Display();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.DownArrow)
                {
                    if (selectedIndex == Options.Length - 1)
                    {
                        selectedIndex = 0;
                    } 
                    else
                    {
                        ++selectedIndex;
                    }
                } 
                else if (keyPressed == ConsoleKey.UpArrow)
                {
                    if (selectedIndex == 0)
                    {
                        selectedIndex = Options.Length - 1;
                    }
                    else
                    {
                        --selectedIndex;
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);
            return selectedIndex;
        }

        public void SetPrompt(string prompt)
        {
            Prompt = prompt;
        }

        public void SetOptions(string[] options)
        {
            Options = options;
        }
    }
}
