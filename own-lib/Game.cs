using System.Collections.Generic;

namespace Lib {
    public class Game : IPublisher {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();
        private int _lastUpdated = 0;

        public int Score { get; set; } = 0;

        public void Play(string input) {
            if (input == " ") {
                Score++;
                if (Score >= _lastUpdated + 10) {
                    NotifySubscribers();
                }
            }
        }

        public void Subscribe(ISubscriber subscriber) {
            if (!_subscribers.Exists(s => s == subscriber)) {
                _subscribers.Add(subscriber);
            }
        }

        public void Unsubscribe(ISubscriber subscriber) {
            if (_subscribers.Exists(s => s == subscriber)) {
                _subscribers.Remove(subscriber);
            }
        }

        public void NotifySubscribers() {
            foreach (var s in _subscribers) {
                s.Update(this);
            }

            _lastUpdated = Score;
        }
    }
}