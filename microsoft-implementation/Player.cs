using System;
using System.Collections.Generic;

namespace Lib 
{
    public class Player : IObservable<Achievement> {
        private List<Achievement> _achievements;
        private List<IObserver<Achievement>> _observers;

        public Player() {
            _achievements = new List<Achievement>{ 
                new Achievement("Win the game"), 
                new Achievement("Lose the game :("), 
                new Achievement("Get 100 points!") 
            };
        }

        public IDisposable Subscribe(IObserver<Achievement> observer) {
            
            return new Unsubscriber<Achievement>(_observers, observer);
        }
    }
}