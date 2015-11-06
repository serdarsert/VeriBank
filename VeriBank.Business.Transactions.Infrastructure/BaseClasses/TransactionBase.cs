using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriBank.Business.Transactions.Infrastructure.Interfaces;

namespace VeriBank.Business.Transactions.Infrastructure.BaseClasses
{
    public abstract class TransactionBase<T> : ITransaction where T : ITransactionManager, new()
    {
        public TransactionBase()
        {
            manager = new T();
        }
        private T manager;

        public T Manager
        {
            get { return manager; }
        }

        public abstract void Execute(ITransactionRequest request, ITransactionResponse response);

        public abstract void Fetch(ITransactionRequest request, ITransactionResponse response);

        public abstract void Confirm(ITransactionRequest request, ITransactionResponse response);
    }
}
