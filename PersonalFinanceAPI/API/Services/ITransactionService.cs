using PersonalFinanceAPI.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalFinanceAPI.API.Services
{
    public interface ITransactionService
    {
        Task<IEnumerable<TransactionDto>> GetAllAsync();
        Task<TransactionDto> GetByIdAsync(int id);
        Task AddAsync(TransactionDto transactionDto);
        Task UpdateAsync(int id, TransactionDto transactionDto);
        Task DeleteAsync(int id);
    }
}