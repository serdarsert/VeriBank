using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeLite;

namespace VeriBank.Business.Transactions.Infrastructure.Interfaces
{
    [TsInterface]
    public interface ITransactionResponse
    {
        TransactionResult Result { get; set; }
    }
}
