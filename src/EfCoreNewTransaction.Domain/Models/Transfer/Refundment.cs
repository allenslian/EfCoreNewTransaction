using System;

namespace EfCoreNewTransaction.Domain.Transfer
{
    /// <summary>
    /// Transfer order refund
    /// </summary>
    public class Refundment
    {
        public long Id { get; set; }

        public long OrderId { get; set; }

        public StatusCodes Status { get; set; }

        public string Reason { get; set; }

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