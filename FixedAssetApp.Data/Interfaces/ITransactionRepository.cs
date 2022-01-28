using FixedAssetApp.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssetApp.Data.Interfaces
{
    public interface ITransactionRepository
    {
        Task Add(Transaction transaction);
        Task Update(Transaction transaction);
        Task Delete(int id);
        Asset GetTransaction(int id);
        IEnumerable<Transaction> GetAllTransactions();
    }
}
