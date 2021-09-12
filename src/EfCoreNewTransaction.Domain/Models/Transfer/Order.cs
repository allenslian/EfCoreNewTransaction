using System;
using System.Collections.Generic;
using EfCoreNewTransaction.Infrastructure.Domain;
using MoreLinq;

namespace EfCoreNewTransaction.Domain.Transfer
{
    /// <summary>
    /// Transfer order
    /// </summary>
    public class Order : AggregateRoot<long>
    {
        #region Fields/Properties

        /// <summary>
        /// Order id
        /// </summary>
        public Guid OrderId { get; set; }

        /// <summary>
        /// Order number
        /// </summary>
        public string OrderNo { get; set; }

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
        /// online/offline
        /// </summary>
        public bool IsOnline { get; set; } = true;

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

        /// <summary>
        /// transfer order details
        /// </summary>
        public IList<OrderDetail> Details { get; private set; }

        #endregion

        public Order()
        {
            Details = new List<OrderDetail>(5);
        }

        public void AddDetails(params OrderDetail[] details)
        {
            if (details == null || details.Length == 0)
            {
                return;
            }
            
            details.ForEach(m => {
                Details.Add(m);
            });
        }

        public void Apply()
        {
            Step = Steps.Apply;
            Status = StatusCodes.Processing;
            Details.ForEach(m => {
                m.Step = Steps.Apply;
                m.Status = StatusCodes.Processing;
            });

            // TODO: send order applied event.
            RaiseEvent(new OrderAppliedEvent(this));
        }

        public void NoteOrderApplySucceeded()
        {

        }

        public void NoteOrderApplyFailed()
        {

        }

        public void NoteOrderApplyPaid()
        {

        }

        private void EnsureOneOrderDetailAtLeast()
        {
            if (Details == null || Details.Count == 0)
            {
                throw new Exception();
            }
        }
    }
}
