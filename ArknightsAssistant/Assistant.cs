using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArknightsAssistant
{
    internal class Assistant
    {
        public void Run()
        {
            string prompt = @" █████╗ ██████╗ ██╗  ██╗███╗   ██╗██╗ ██████╗ ██╗  ██╗████████╗███████╗
██╔══██╗██╔══██╗██║ ██╔╝████╗  ██║██║██╔════╝ ██║  ██║╚══██╔══╝██╔════╝
███████║██████╔╝█████╔╝ ██╔██╗ ██║██║██║  ███╗███████║   ██║   ███████╗
██╔══██║██╔══██╗██╔═██╗ ██║╚██╗██║██║██║   ██║██╔══██║   ██║   ╚════██║
██║  ██║██║  ██║██║  ██╗██║ ╚████║██║╚██████╔╝██║  ██║   ██║   ███████║
╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝ ╚═════╝ ╚═╝  ╚═╝   ╚═╝   ╚══════╝
                                                                       
 █████╗ ███████╗███████╗██╗███████╗████████╗ █████╗ ███╗   ██╗████████╗
██╔══██╗██╔════╝██╔════╝██║██╔════╝╚══██╔══╝██╔══██╗████╗  ██║╚══██╔══╝
███████║███████╗███████╗██║███████╗   ██║   ███████║██╔██╗ ██║   ██║   
██╔══██║╚════██║╚════██║██║╚════██║   ██║   ██╔══██║██║╚██╗██║   ██║   
██║  ██║███████║███████║██║███████║   ██║   ██║  ██║██║ ╚████║   ██║   
╚═╝  ╚═╝╚══════╝╚══════╝╚═╝╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═══╝   ╚═╝ 

Welcome to Arknights Assistant!
Use Up and Down Arrow keys to navigate the menu
";
            string[] options = { "Start", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = 0;
            while(true)
            {
                selectedIndex = mainMenu.Run();
                enterOption(selectedIndex);
            }
        }

        private void enterOption(int optionNumber)
        {
            Clear();
            switch(optionNumber)
            {
                case 0:
                    Automation automation= new Automation();
                    automation.Run();
                    break;
                case 1:
                    About about= new About();
                    about.Run();    
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
