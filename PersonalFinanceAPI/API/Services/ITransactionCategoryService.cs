using PersonalFinanceAPI.Core.DTOs;

namespace PersonalFinanceAPI.API.Services
{
    public interface ITransactionCategoryService
    {
        Task<IEnumerable<TransactionCategoryDto>> GetAllAsync();
        Task<TransactionCategoryDto> GetByIdAsync(int id);
        Task<int> AddAsync(TransactionCategoryDto categoryDto);
        Task UpdateAsync(int id, TransactionCategoryDto categoryDto);
        Task DeleteAsync(int id);
    }
}