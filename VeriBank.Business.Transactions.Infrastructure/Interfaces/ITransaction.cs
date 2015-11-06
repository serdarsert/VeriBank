using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriBank.Business.Transactions.Infrastructure.Interfaces
{
    public interface ITransaction
    {
        void Execute(ITransactionRequest request, ITransactionResponse response);
        void Fetch(ITransactionRequest request, ITransactionResponse response);
        void Confirm(ITransactionRequest request, ITransactionResponse response);
    }
}
