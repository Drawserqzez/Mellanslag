using System;
using System.Collections.Generic;

namespace lib
{
    public class Unsubscriber : IDisposable
    {
        private List<IObserver<Achievement>> _observers;
        private IObserver<Achievement> _observer;

        public Unsubscriber(
            List<IObserver<Achievement>> observers, IObserver<Achievement> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (! (_observers == null)) 
            { _observers.Remove(_observer); }
        }
    }
}