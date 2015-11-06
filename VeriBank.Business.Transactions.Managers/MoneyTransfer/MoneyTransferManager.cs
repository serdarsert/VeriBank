using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriBank.Business.Transactions.Infrastructure;
using VeriBank.Business.Transactions.Infrastructure.BaseClasses.MoneyTransfer;
using VeriBank.Business.Transactions.Infrastructure.Interfaces;

namespace VeriBank.Business.Transactions.Managers.MoneyTransfer
{
    public class MoneyTransferManager:ITransactionManager
    {
        public void DoAction(ITransactionRequest request, ITransactionResponse response)
        {
            // TODO: open transaction.

            MoneyTransferRequestBase moneyTransferRequest = request as MoneyTransferRequestBase;

            // TODO: Do Action

            response.Result = new TransactionResult { IsSuccess = true };
        }
    }
}
