using System.Collections.Generic;

namespace EfCoreNewTransaction.Domain.Transfer
{
    public class Service
    {
        public void Apply(Order order, IList<Operation> operations)
        {
            
        }

        public void ReceiveApplyResults(Order order, IList<Operation> operations)
        {

        }

        public void Confirm(Order order, IList<Operation> operations)
        {

        }

        public void ReceiveConfirmResult(Order order, IList<Operation> operations)
        {

        }

        public void Cancel(Order order, IList<Operation> operations)
        {

        }

        public void ReceiveCancelResult(Order order, IList<Operation> operations)
        {

        }

        public void Issue(Issue issue, IList<Operation> operations)
        {

        }
    }
}