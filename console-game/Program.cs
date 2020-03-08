using System;
using Lib;

namespace console_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            AchievementUnlocker unlocker1 = new AchievementUnlocker(new Achievement("Win the game :]", (int)Game.GameState.Won, true));
            AchievementUnlocker unlocker2 = new AchievementUnlocker(new Achievement("Lose the game :(", (int)Game.GameState.Lost, true));
            AchievementUnlocker unlocker3 = new AchievementUnlocker(new Achievement("Get 100 points!", 100, false));

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

            System.Console.WriteLine();

        }
    }
}
