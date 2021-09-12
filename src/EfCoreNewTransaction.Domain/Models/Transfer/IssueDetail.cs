using System;

namespace EfCoreNewTransaction.Domain.Transfer
{
    public class IssueDetail
    {
        /// <summary>
        /// Identity
        /// </summary>
        public long Id { get; set; }

        public long IssueId { get; set; }

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
    }
}