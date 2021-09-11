using System;

namespace EfCoreNewTransaction.Domain.Transfer
{
    public class Order
    {
        #region Fields/Properties

        /// <summary>
        /// Identity
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Order id
        /// </summary>
        public Guid OrderId { get; set; }

        /// <summary>
        /// Order number
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// Current operation
        /// </summary>
        public Guid? OperationId { get; set; }

        /// <summary>
        /// Current operation step (redundancy)
        /// </summary>
        public Steps? Step { get; set; }
        
        /// <summary>
        /// Current operation status (redundancy)
        /// </summary>
        public StatusCodes? Status { get; set; }

        /// <summary>
        /// Payer account
        /// </summary>
        public Account Payer { get; set; }

        /// <summary>
        /// Total order amount
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Business identity for other app
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// Web hook
        /// </summary>
        public string WebHookUrl { get; set; } = string.Empty;

        /// <summary>
        /// 线上/线下
        /// </summary>
        public bool IsOnline { get; set; } = true;

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public string CreatedBy { get; set; }

        public DateTime DateModified { get; set; } = DateTime.Now;

        public string ModifiedBy { get; set; }

        public byte[] Version { get; set; }

        #endregion
    }
}
