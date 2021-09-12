
using EfCoreNewTransaction.Infrastructure.Domain;

namespace EfCoreNewTransaction.Domain.Transfer
{
    /// <summary>
    /// Account is value object.
    /// </summary>
    public class Account : IValueObject
    {
        public Account(string id, string name, string number)
        {
            Id = id;
            Name = name;
            Number = number;
        }

        /// <summary>
        /// Payer/Payee id
        /// </summary>
        public string Id { get; private set; }
        
        /// <summary>
        /// Payer/Payee account number
        /// </summary>
        public string Number { get; private set; }

        /// <summary>
        /// Payer/Payee account name
        /// </summary>
        public string Name { get; private set; }
    }
}