using System;
using System.Collections.Generic;

namespace console.Menu {
    public static class ConsoleMenu {
        public static int DisplayMenu(List<string> menuItems) {            
            int currentIndex = 0;
            while(true) {
                foreach (var s in menuItems) {
                    if (menuItems.FindIndex(st => st == s) == currentIndex) {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine(s);
                }

                var pressedKey = Console.ReadKey(true).Key;

                switch (pressedKey) {
                    case ConsoleKey.UpArrow: 
                        currentIndex = (currentIndex <= 0) ? menuItems.Count - 1 : currentIndex - 1;
                        break;

                    case ConsoleKey.DownArrow: 
                        currentIndex = (currentIndex >= menuItems.Count - 1) ? 0 : currentIndex + 1;
                        break;
                    
                    case ConsoleKey.Enter: 
                        return currentIndex;
                }
            }
        }        
    }
}