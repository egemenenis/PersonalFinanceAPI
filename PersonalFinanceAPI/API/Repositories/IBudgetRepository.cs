using PersonalFinanceAPI.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalFinanceAPI.API.Repositories
{
    public interface IBudgetRepository
    {
        Task<IEnumerable<Budget>> GetAllAsync();
        Task<Budget> GetByIdAsync(int id);
        Task AddAsync(Budget budget);
        Task UpdateAsync(Budget budget);
        Task DeleteAsync(int id);
    }
}