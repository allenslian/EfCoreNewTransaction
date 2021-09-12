using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EfCoreNewTransaction.Infrastructure.Domain
{
    /// <summary>
    /// Aggregate root base class
    /// </summary>
    /// <typeparam name="TKey">Identity type</typeparam>
    public abstract class AggregateRoot<TKey> : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// Identity of the aggregate root instance.
        /// </summary>
        /// <value>TKey</value>
        public TKey Id { get; protected set; }

        /// <summary>
        /// Domain event collections about the aggregate root instance.
        /// </summary>
        private IList<IEvent> _events;

        /// <summary>
        /// Default constructor
        /// </summary>
        protected AggregateRoot()
        {
            _events = new List<IEvent>(2);
        }

        /// <summary>
        /// Apply one domain event to the instance.
        /// </summary>
        protected void RaiseEvent(IEvent @event)
        {
            _events.Add(@event);
        }

        /// <summary>
        /// Get all the events about the instance.
        /// </summary>
        /// <value>IReadOnlyCollection</value>
        public ReadOnlyCollection<IEvent> Events
        {
            get
            {
                return new ReadOnlyCollection<IEvent>(_events);
            }
        }
    }
}