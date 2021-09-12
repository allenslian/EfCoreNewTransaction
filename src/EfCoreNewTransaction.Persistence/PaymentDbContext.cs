
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
        /// Transfer Order Details
        /// </summary>
        DbSet<Transfer.OrderDetail> TransferOrderDetails { get; set; }

        /// <summary>
        /// Initialize entity configurations
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TransferOrderMapping());
            modelBuilder.ApplyConfiguration(new TransferOrderDetailMapping());
            
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseLoggerFactory()

            base.OnConfiguring(optionsBuilder);
        }

        public PaymentDbContext(DbContextOptions<PaymentDbContext> options) : base(options)
        {
        }
    }
}