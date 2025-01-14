using PersonalFinanceAPI.Core.Entities;

namespace PersonalFinanceAPI.API.Repositories
{
    public interface ITransactionCategoryRepository
    {
        Task<IEnumerable<TransactionCategory>> GetAllAsync();
        Task<TransactionCategory> GetByIdAsync(int id);
        Task AddAsync(TransactionCategory category);
        Task UpdateAsync(TransactionCategory category);
        Task DeleteAsync(int id);
    }
}