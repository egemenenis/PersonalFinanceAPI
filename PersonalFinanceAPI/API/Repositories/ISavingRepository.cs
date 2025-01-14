using PersonalFinanceAPI.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalFinanceAPI.API.Repositories
{
    public interface ISavingRepository
    {
        Task<IEnumerable<Saving>> GetAllAsync();
        Task<Saving> GetByIdAsync(int id);
        Task AddAsync(Saving saving);
        Task UpdateAsync(Saving saving);
        Task DeleteAsync(int id);
    }
}