using System;

namespace EfCoreNewTransaction.Domain.Transfer
{
    public class Issue
    {
        public long Id { get; set; }

        public string OrderId { get; set; }

        public Account Payer { get; set; }

        public decimal TotalAmount { get; set; }

        public IssueKinds IssueType { get; set; }

        /// <summary>
        /// Current status
        /// </summary>
        public StatusCodes? Status { get; set; }

        /// <summary>
        /// Status description will be successfull/failed message.
        /// </summary>
        public string StatusDescription { get; set; }

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

        /// <summary>
        /// row version
        /// </summary>
        public byte[] Version { get; set; }

    }
}