using PersonalFinanceAPI.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalFinanceAPI.API.Services
{
    public interface ISavingService
    {
        Task<IEnumerable<SavingDto>> GetAllAsync();
        Task<SavingDto> GetByIdAsync(int id);
        Task AddAsync(SavingDto savingDto);
        Task UpdateAsync(int id, SavingDto savingDto);
        Task DeleteAsync(int id);
    }
}