﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriBank.Business.Transactions.Infrastructure.Interfaces
{
    public interface ITransactionResponse
    {
        TransactionResult Result { get; set; }
    }
}