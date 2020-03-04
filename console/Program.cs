using System;
using System.Collections.Generic;
using console.Menu;

namespace console
{
    class Program
    {
        enum MenuOptions { Play, Achievements, Quit }
        static void Main(string[] args)
        {            
            List<string> menuItems = new List<string>{ "Play", "Achievements", "Quit" };
            
            while (true) {
                switch((MenuOptions)ConsoleMenu.DisplayMenu(menuItems)) {
                    case MenuOptions.Play: 
                        // TODO: Implement Game-logic from library
                        break; 
                    case MenuOptions.Achievements:
                        // TODO: Implement Game-logic from library
                        break;
                    case MenuOptions.Quit:
                        Console.WriteLine("Thanks for playing!");
                        Console.ReadKey(true);
                        return;                          
                }
            }
        }
    }
}
