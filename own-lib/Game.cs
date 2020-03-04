using System.Collections.Generic;
using System.Linq;

namespace Lib {
    public class Game : IPublisher {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();
        private int _lastUpdated = 0;

        public int Score { get; set; } = 0;
        public bool HasPlayerLost { get; private set; } = false;

        public void Play(string input) {
            // TODO: Implement loss-condition
            if (input == " ") {
                Score++;
                if (Score >= _lastUpdated + 10) {
                    NotifySubscribers();
                }
            }
            else if (input == "Ð") {
                Score = 999999999;
                NotifySubscribers();
            }
        }

        public void Subscribe(ISubscriber subscriber) {
            if (!_subscribers.Exists(s => s == subscriber)) {
                _subscribers.Add(subscriber);
            }
        }

        public void Subscribe(List<ISubscriber> subscribers) {
            foreach (var s in subscribers.ToList()) {
                Subscribe(s);
            }
        }

        public void Unsubscribe(ISubscriber subscriber) {
            if (_subscribers.Exists(s => s == subscriber)) {
                _subscribers.Remove(subscriber);
            }
        }

        public void NotifySubscribers() {
            foreach (var s in _subscribers.ToList()) {
                s.Update(this);
            }

            _lastUpdated = Score;
        }
    }
}