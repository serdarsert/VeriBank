using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriBank.Business.Transactions.Infrastructure.BaseClasses.MoneyTransfer
{
    public class MoneyTransferRequestBase : TransactionRequestBase
    {
        public string ToAccount { get; set; }
        public string FromAccount { get; set; }
        public decimal Amount { get; set; }
    }
}
