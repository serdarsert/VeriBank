using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriBank.Business.Transactions.Infrastructure;
using VeriBank.Business.Transactions.Infrastructure.Interfaces;

namespace VeriBank.Business.Transactions.MoneyTransfer
{
    public class MoneyTransferTransaction : ITransaction
    {
        public void Execute(ITransactionRequest request, ITransactionResponse response)
        {

        }

        public void Fetch(ITransactionRequest request, ITransactionResponse response)
        {

        }

        public void Confirm(ITransactionRequest request, ITransactionResponse response)
        {

        }
    }
}
