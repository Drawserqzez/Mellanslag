using System.Collections.Generic;

namespace AutoConsole
{
    public interface IProvider
    {
        List<ISubscriber> GetSubscribers();

        public void Subscribe(ISubscriber subscriber);
        public void UnSubscribe(ISubscriber subscriber);
        public void NotifySubscribers();
        public bool Update();
    }
}