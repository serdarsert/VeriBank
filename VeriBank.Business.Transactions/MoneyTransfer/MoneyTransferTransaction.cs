using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriBank.Business.Transactions.Infrastructure;
using VeriBank.Business.Transactions.Infrastructure.BaseClasses;
using VeriBank.Business.Transactions.Infrastructure.Interfaces;
using VeriBank.Business.Transactions.Managers.MoneyTransfer;

namespace VeriBank.Business.Transactions.MoneyTransfer
{
    public class MoneyTransferTransaction : TransactionBase<MoneyTransferManager>
    {
        public override void Execute(ITransactionRequest request, ITransactionResponse response)
        {
            Manager.DoAction(request, response);
        }

        public override void Fetch(ITransactionRequest request, ITransactionResponse response)
        {

        }

        public override void Confirm(ITransactionRequest request, ITransactionResponse response)
        {

        }
    }
}
