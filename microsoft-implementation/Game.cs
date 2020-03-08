using System;
using System.Collections.Generic;

namespace Lib 
{
    public class Game : IObservable<Achievement> {
        public enum GameState { Playing, Won, Lost }
        private List<IObserver<Achievement>> _observers;
        private int _points = 0;
        private GameState _currentState = GameState.Playing;

        public GameState CurrentState { get { return _currentState; }}
        public int Points { get { return _points; }}

        public Game() {
            // _achievements = new List<Achievement>{ 
            //     new Achievement("Win the game", 1, true), 
            //     new Achievement("Lose the game :(", 2, true), 
            //     new Achievement("Get 100 points!", 100, false) 
            // };
            _observers = new List<IObserver<Achievement>>();
        }

        public IDisposable Subscribe(IObserver<Achievement> observer) {
            _observers.Add(observer);
            return new Unsubscriber<Achievement>(_observers, observer);
        }

        public void Play(ConsoleKey keyPressed) {
            bool updated = false;
            Achievement achievement = new Achievement();

            if (keyPressed == ConsoleKey.Backspace) {
                _currentState = GameState.Lost;
                achievement = new Achievement("Lose the game :(", (int)GameState.Lost, true);
                updated = true;
            }
            else if (keyPressed == ConsoleKey.Spacebar) {
                _points++;
                achievement = new Achievement("Get 100 points!", 100, false);
                updated = (_points > 100);
            }
            else if (keyPressed == ConsoleKey.Enter) {
                _currentState = GameState.Won;
                achievement = new Achievement("Win the game :]", (int)GameState.Won, true);
                updated = true;
            }

            if (updated) {
                foreach (var observer in _observers) {
                    observer.OnNext(achievement);
                }
            }

        }
    }
}