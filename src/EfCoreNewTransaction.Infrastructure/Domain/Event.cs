using System;

namespace EfCoreNewTransaction.Infrastructure.Domain
{
    public interface IEvent
    {
        Guid Id { get; }

        DateTime OccurredOn { get; }

        string Topic { get; }

        string Key { get; }

        object Payload { get; }
    }

    public abstract class EventBase<T> : IEvent where T : class
    {
        protected EventBase()
        {
            Id = Guid.NewGuid();
            OccurredOn = DateTime.Now;
        }

        protected EventBase(string topic, string key, T payload) : this()
        {
            Topic = topic ?? throw new ArgumentNullException(nameof(topic));
            Key = key ?? throw new ArgumentNullException(nameof(key));
            Payload = payload ?? throw new ArgumentNullException(nameof(payload));
        }

        public Guid Id { get; private set; }

        public DateTime OccurredOn { get; private set; }

        public string Topic { get; protected set; }

        public string Key { get; protected set; }

        public object Payload { get; protected set; }
    }
}