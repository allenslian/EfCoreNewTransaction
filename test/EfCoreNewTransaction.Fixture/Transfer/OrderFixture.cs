using System;
using Xunit;
using Shouldly;

using EfCoreNewTransaction.Infrastructure.Domain;
using Transfer = EfCoreNewTransaction.Domain.Transfer;


namespace EfCoreNewTransaction.Fixture
{
    public class OrderFixture
    {
        [Fact]
        public void ShouldAddTransferOrderAndIssue()
        {
            var order = GenerateOrderAndDetails();
            order.Step.ShouldBeNull();
            order.Status.ShouldBeNull();

            order.Apply();
            order.Step.ShouldBe(Transfer.Steps.Apply);
            order.Status.ShouldBe(Transfer.StatusCodes.Processing);

            order.Events.ShouldNotBeEmpty();
            order.Events.Count.ShouldBe(1);
            order.Events[0].Payload.ShouldBeOfType<Transfer.Order>();
        }

        private Transfer.Order GenerateOrderAndDetails()
        {
            var order = new Transfer.Order();
            order.OrderId = Guid.NewGuid();
            order.OrderNo = "";
            order.Step = null;
            order.Status = null;
            order.Payer = new Transfer.Account("27c9c355-48d5-1a0e-b652-625e5017eb5c", "良匠科技有限公司", "3301001002003");
            order.TotalAmount = 100.00M;
            order.BizId = "37c9c355-48d5-1a0e-b652-625e5017eb5c";
            order.WebHookUrl = "http://localhost:5000/callback";
            order.IsOnline = true;
            order.CreatedBy = "Allen";
            order.ModifiedBy = "Allen";

            order.AddDetails(
                new[]
                {
                    new Transfer.OrderDetail
                    {
                        OperationId = null,
                        Payee = new Transfer.Account("27c9c355-48d5-1a0e-b652-625e5017eb6c", "辽宁沃锐达有限公司", "4301001002003"),
                        Amount = 20.00M,
                        Step = null,
                        Status = null,
                        StatusDescription = null,
                        Notes = "服务费",
                        IsAgent = false,
                        BizId = "38c9c355-48d5-1a0e-b652-625e5017eb5c",
                        CreatedBy = "Allen",
                        ModifiedBy = "Allen"
                    },
                    new Transfer.OrderDetail
                    {
                        OperationId = null,
                        Payee = new Transfer.Account("27c9c355-48d5-1a0e-b652-625e5017eb6c", "辽宁沃锐达有限公司", "3301001002003"),
                        Amount = 20.00M,
                        Step = null,
                        Status = null,
                        StatusDescription = null,
                        Notes = "项目费",
                        IsAgent = true,
                        BizId = "39c9c355-48d5-1a0e-b652-625e5017eb5c",
                        CreatedBy = "Allen",
                        ModifiedBy = "Allen"
                    }
                });
            return order;
        }
    }
}
