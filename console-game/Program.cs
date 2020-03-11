using System;
using System.Collections.Generic;
using Lib;

namespace console_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Achievement win = new Achievement("Win the game :]", (int)Game.GameState.Won, true);
            Achievement lose = new Achievement("Lose the game :(", (int)Game.GameState.Lost, true);
            Achievement points = new Achievement("Get 100 points!", 100, false);

            List<Achievement> achievements = new List<Achievement>(); 
            achievements.Add(win);
            achievements.Add(lose);
            achievements.Add(points);

            AchievementUnlocker unlocker1 = new AchievementUnlocker(win);
            AchievementUnlocker unlocker2 = new AchievementUnlocker(lose);
            AchievementUnlocker unlocker3 = new AchievementUnlocker(points);

            unlocker1.Subscribe(game);
            unlocker2.Subscribe(game);
            unlocker3.Subscribe(game);

            while(game.CurrentState == Game.GameState.Playing) {
                System.Console.WriteLine("Press key! Points: {0}", game.Points);
                game.Play(Console.ReadKey(true).Key);
            }

            switch(game.CurrentState) {
                case Game.GameState.Won:
                    System.Console.WriteLine("You won! You got {0} points!", game.Points);
                    break;

                case Game.GameState.Lost:
                    System.Console.WriteLine("You lost :( You got {0} points", game.Points);
                    break;
            }

            foreach (var a in achievements) {
                if (a.IsUnlocked) {
                    System.Console.WriteLine("You also unlocked: {0}", a.Name);
                }
            }            

            System.Console.WriteLine();

        }
    }
}
