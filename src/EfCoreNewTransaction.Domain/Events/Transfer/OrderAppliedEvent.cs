// using System;
// using System.Collections.Generic;
// using MoreLinq;

using EfCoreNewTransaction.Infrastructure.Domain;

namespace EfCoreNewTransaction.Domain.Transfer
{
    public class OrderAppliedEvent : EventBase<Order>
    {
        public OrderAppliedEvent(Order order) : base("Payment.Transfer", order.OrderId.ToString(), order)
        {
            // if (order.Details == null || order.Details.Count == 0)
            // {
            //     throw new ArgumentException("Missing order details!!!");
            // }

            // OrderId = order.Id;
            // BizId = order.BizId;
            // Payer = order.Payer;
            // TotalAmount = order.TotalAmount;
            // Step = order.Step.Value;
            // Status = order.Status.Value;

            // Items = new List<OrderItem>(5);
            // order.Details.ForEach(m =>
            // {
            //     Items.Add(new OrderItem(
            //         m.BizId,
            //         m.Payee,
            //         m.Amount,
            //         m.Step.Value,
            //         m.Status.Value));
            // });
        }

        // public long OrderId { get; private set; }

        // public string BizId { get; private set; }

        // public Account Payer { get; private set; }

        // public decimal TotalAmount { get; private set; }

        // public Steps Step { get; private set; }

        // public StatusCodes Status { get; private set; }

        // public List<OrderItem> Items { get; private set; }

        // public class OrderItem
        // {
        //     public OrderItem(string bizId, Account payee, decimal amount,
        //         Steps step, StatusCodes status)
        //     {
        //         BizId = bizId ?? throw new ArgumentNullException(nameof(bizId));
        //         Payee = payee ?? throw new ArgumentNullException(nameof(payee));
        //         Amount = amount;
        //         Step = step;
        //         Status = status;
        //     }

        //     public string BizId { get; private set; }

        //     public Account Payee { get; private set; }

        //     public decimal Amount { get; private set; }

        //     public Steps Step { get; private set; }

        //     public StatusCodes Status { get; private set; }
        // }
    }
}