using System;

namespace EfCoreNewTransaction.Domain.Transfer
{
    public class OrderDetail
    {
        #region Fields/Properties

        /// <summary>
        /// Identity
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Order id
        /// </summary>
        public long OrderId { get; set; }

        /// <summary>
        /// Payee account
        /// </summary>
        public Account Payee { get; set; }

        public decimal Amount { get; set; }

        public Steps CurrentStep { get; set; }

        public StatusCodes CurrentStatus { get; set; }

        public DateTime DateCreated { get; set; }

        public string CreatedBy { get; set; }

        public DateTime DateModified { get; set; }

        public string ModifiedBy { get; set; }

        #endregion
    }
}