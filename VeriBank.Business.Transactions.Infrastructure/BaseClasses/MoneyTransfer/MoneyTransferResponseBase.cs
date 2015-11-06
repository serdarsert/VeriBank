﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriBank.Business.Transactions.Infrastructure.Interfaces;

namespace VeriBank.Business.Transactions.Infrastructure.BaseClasses.MoneyTransfer
{
    public class MoneyTransferResponseBase : ITransactionResponse
    {
        public TransactionResult Result
        {
            get;
            set;
        }
    }
}
