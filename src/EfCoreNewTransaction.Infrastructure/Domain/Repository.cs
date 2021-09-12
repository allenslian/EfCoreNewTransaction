using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace EfCoreNewTransaction.Infrastructure.Domain
{
    public interface IRepository<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : AggregateRoot<TKey>
    {
        /// <summary>
        /// Find one aggregate root instance or more ones by predicate
        /// </summary>
        /// <param name="predicate">which items to be found</param>
        /// <param name="cancellationToken">cancellation token</param>
        /// <returns></returns>
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Save one aggregate root instance.
        /// </summary>
        /// <param name="model">one aggregate root instance</param>
        /// <param name="autoSave">whether to persist to database</param>
        /// <param name="cancellationToken">cancellation token</param>
        /// <returns></returns>
        Task SaveAsync(TEntity model, bool autoSave = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove one aggregate root instance.
        /// </summary>
        /// <param name="predicate">which items to be removed</param>
        /// <param name="autoSave">whether to persist to database</param>
        /// <param name="cancellationToken">cancellation token</param>
        /// <returns></returns>
        Task RemoveAsync(Expression<Func<TEntity, bool>> predicate, bool autoSave = false, CancellationToken cancellationToken = default);
    }
}