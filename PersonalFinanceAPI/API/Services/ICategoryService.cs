using PersonalFinanceAPI.Core.DTOs;

namespace PersonalFinanceAPI.API.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllAsync();
        Task<CategoryDto> GetByIdAsync(int id);
        Task<int> AddAsync(CategoryDto categoryDto);
        Task UpdateAsync(int id, CategoryDto categoryDto);
        Task DeleteAsync(int id);
    }
}