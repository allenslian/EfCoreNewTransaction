
using Microsoft.EntityFrameworkCore;

using Transfer = EfCoreNewTransaction.Domain.Transfer;
using EfCoreNewTransaction.Persistence.Configuration;

namespace EfCoreNewTransaction.Persistence
{
    public class PaymentDbContext : DbContext
    {
        /// <summary>
        /// Transfer Orders
        /// </summary>
        DbSet<Transfer.Order> TransferOrders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TransferOrderMapping());
            
            base.OnModelCreating(modelBuilder);
        }

        public PaymentDbContext(DbContextOptions<PaymentDbContext> options) : base(options)
        {
        }
    }
}