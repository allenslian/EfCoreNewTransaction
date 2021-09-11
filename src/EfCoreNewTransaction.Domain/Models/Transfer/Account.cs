
namespace EfCoreNewTransaction.Domain.Transfer
{
    /// <summary>
    /// Account is value object.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Payer/Payee id
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// Payer/Payee account number
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Payer/Payee account name
        /// </summary>
        public string Name { get; set; }
    }
}