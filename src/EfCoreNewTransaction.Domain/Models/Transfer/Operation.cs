using System;

namespace EfCoreNewTransaction.Domain.Transfer
{
    public class Operation
    {
        /// <summary>
        /// 操作ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 引用ID，用来标识主键
        /// </summary>
        public string ReferenceId { get; set; }

        /// <summary>
        /// 引用来源
        /// </summary>
        public string ReferenceSource { get; set; }

        /// <summary>
        /// 银行订单号
        /// </summary>
        public string BankOrderNo { get; set; }

        /// <summary>
        /// 银行流水号
        /// </summary>
        public string BankSeqNo { get; set; }

        /// <summary>
        /// 当前步骤
        /// </summary>
        public Steps Step { get; set; }

        /// <summary>
        /// 当前状态
        /// </summary>
        public StatusCodes Status { get; set; }

        public string PaymentUrl { get; set; }

        public Account Payer { get; set; }

        public Account Payee { get; set; }

        public decimal Amount { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public byte[] Version { get; set; }
    }
}