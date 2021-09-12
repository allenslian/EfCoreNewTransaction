using System;
using EfCoreNewTransaction.Infrastructure.Domain;

namespace EfCoreNewTransaction.Domain.Transfer
{
    /// <summary>
    /// Transfer order detail
    /// </summary>
    public class OrderDetail : IEntity<long>
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
        /// Current operation
        /// </summary>
        public Guid? OperationId { get; set; }

        /// <summary>
        /// Payee account
        /// </summary>
        public Account Payee { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Current step
        /// </summary>
        public Steps? Step { get; set; }

        /// <summary>
        /// Current status
        /// </summary>
        public StatusCodes? Status { get; set; }

        /// <summary>
        /// Status description will be successfull/failed message.
        /// </summary>
        public string StatusDescription { get; set; }

        /// <summary>
        /// Order detail notes
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Whether the detail is agency part or not
        /// </summary>
        public bool IsAgent { get; set; }

        /// <summary>
        /// Business identity for other app
        /// </summary>
        public string BizId { get; set; }
        
        /// <summary>
        /// Date created
        /// </summary>
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Created by
        /// </summary>
        public string CreatedBy { get; set; }
        
        /// <summary>
        /// Date modified
        /// </summary>
        public DateTime DateModified { get; set; } = DateTime.Now;

        /// <summary>
        /// Modified by
        /// </summary>
        public string ModifiedBy { get; set; }

        #endregion
    }
}