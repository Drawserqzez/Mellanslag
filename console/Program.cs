using System;
using System.Collections.Generic;
using console.Menu;
using Lib;

namespace console
{
    class Program
    {
        enum MenuOptions { Play, Achievements, Quit }
        static void Main(string[] args)
        {            
            List<string> menuItems = new List<string>{ "Play", "Achievements", "Quit" };
            Game game = new Game();
            Player player = new Player();
            game.Subscribe(new List<ISubscriber>(player.Achievements));
                        
            switch((MenuOptions)ConsoleMenu.DisplayMenu(menuItems)) {
                case MenuOptions.Play: 
                    while (!game.HasPlayerLost) {
                        Console.WriteLine(game.Score);
                        game.Play(Console.ReadKey().KeyChar.ToString());
                        foreach (var a in player.Achievements) {
                            if (a.Unlocked) {
                                Console.WriteLine(a.Name);
                            }
                        }
                    }
                    break;                    
                case MenuOptions.Achievements:
                    // TODO: Implement this
                    break;
                case MenuOptions.Quit:
                    Console.WriteLine("Thanks for playing!");
                    Console.ReadKey(true);               
                    return;     
            }
        }
    }
}
