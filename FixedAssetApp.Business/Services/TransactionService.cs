using FixedAssetApp.Business.Interfaces;
using FixedAssetApp.Data.Interfaces;
using FixedAssetApp.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssetApp.Business.Services
{
    public class TransactionService : ITransactionService
    {
        private ITransactionRepository _transactionRepository;
        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public Task Add(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transaction> GetAllTransactions()
        {
            throw new NotImplementedException();
        }

        public Asset GetTransaction(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
