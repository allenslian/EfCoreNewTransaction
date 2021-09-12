using System;

namespace EfCoreNewTransaction.Infrastructure.Domain
{
    public interface IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        TKey Id { get; }
    }
}