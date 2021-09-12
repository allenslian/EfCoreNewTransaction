
namespace EfCoreNewTransaction.Domain.Transfer
{
    public enum Steps
    {
        /// <summary>
        /// 支付申请
        /// </summary>
        Apply = 0x1,

        /// <summary>
        /// 支付解冻
        /// </summary>
        Unfreeze = 0x2,

        /// <summary>
        /// 支付取消
        /// </summary>
        Cancel = 0x3,

        /// <summary>
        /// 发放
        /// </summary>
        Issue = 0x4,

        /// <summary>
        /// 退款
        /// </summary>
        Refund = 0x5,

        /// <summary>
        /// 人为终止
        /// </summary>
        End = 0x10
    }
}