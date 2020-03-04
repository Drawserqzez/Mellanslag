namespace Lib {
    public interface IPublisher {
        void Subscribe(ISubscriber subscriber);
        void Unsubscribe(ISubscriber subscriber);
        void NotifySubscribers();
    }
}