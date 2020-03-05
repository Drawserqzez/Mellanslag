using System;
using System.Collections.Generic;

namespace lib
{
    public class AchievementMonitor : IObservable<Achievement>
    {
        List<IObserver<Achievement>> observers;

        public AchievementMonitor()
        {
            observers = new List<IObserver<Achievement>>();
        }

        public IDisposable Subscribe(IObserver<Achievement> observer)
        {
            
        }
    }
}