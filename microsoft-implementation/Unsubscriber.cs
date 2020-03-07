using System;
using System.Collections.Generic;

namespace Lib 
{
    public class Unsubscriber<Achievement> : IDisposable {
        private List<IObserver<Achievement>> _observers;
        private IObserver<Achievement> _observer;

        public Unsubscriber(List<IObserver<Achievement>> observers, IObserver<Achievement> observer) {
            _observer = observer;
            _observers = observers;
        }

        public void Dispose() {
            if (_observers.Contains(_observer)) {
                _observers.Remove(_observer);
            }
        }
    }
}