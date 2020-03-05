using System;
using System.Collections.Generic;

namespace lib
{
    public class Game : IObservable<Achievement>
    {
        private List<IObserver<Achievement>> _achievments;

        public IDisposable Subscribe(IObserver<Achievement> observer) {
            if (!_achievments.Contains(observer)) {
                _achievments.Add(observer);
            }
            return (IDisposable)observer;
        }

        public void Unsubscribe(IObserver<Achievement> observer)
        {
            _achievments.Remove(observer);
        }

        public Game()
        {
            _achievments = new List<IObserver<Achievement>>();
        }
    }
}