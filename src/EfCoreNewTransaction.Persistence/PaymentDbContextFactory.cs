using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EfCoreNewTransaction.Persistence
{
    internal class PaymentDbContextFactory : IDesignTimeDbContextFactory<PaymentDbContext>
    {
        public PaymentDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PaymentDbContext>();
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=test; User Id=sa; Password=123T@z234;");

            return new PaymentDbContext(optionsBuilder.Options);
        }
    }
}