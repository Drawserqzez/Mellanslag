using System;
using System.Collections.Generic;

namespace AutoConsole
{
    public class OnEnterProvider : IProvider
    {
        private List<ISubscriber> _subscribers;

        public OnEnterProvider()
        {
            _subscribers = new List<ISubscriber>();
        }

        public bool Update()
        {
            ConsoleKeyInfo pressedKey = Console.ReadKey();

            if(pressedKey.Key == ConsoleKey.Enter)
            { NotifySubscribers(); }

            else if(pressedKey.Key == ConsoleKey.Q)
                { return true; }
                
            return false;
        }

        public List<ISubscriber> GetSubscribers()
        {
            return _subscribers;
        }

        public void NotifySubscribers()
        {
            foreach (var subscriber in _subscribers)
                { subscriber.Update(); }
        }

        public void Subscribe(ISubscriber subscriber)
        {
            if (!_subscribers.Contains(subscriber))
                { _subscribers.Add(subscriber); }
        }

        public void UnSubscribe(ISubscriber subscriber)
        {
            if (!_subscribers.Contains(subscriber))
                { _subscribers.Remove(subscriber); }
        }
    }
}