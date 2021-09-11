
namespace EfCoreNewTransaction.Domain.Transfer
{
    public enum StatusCodes
    {
        Pending = 0,

        Processing = 1,

        PartialSuccess = 2,

        Success = 3,

        Failure = 4
    }
}