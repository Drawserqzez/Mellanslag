using System;

namespace Lib 
{
    public class AchievementUnlocker : IObserver<Achievement> {
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Achievement value)
        {
            throw new NotImplementedException();
        }
    }
}