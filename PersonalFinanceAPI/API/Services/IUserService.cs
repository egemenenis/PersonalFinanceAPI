using PersonalFinanceAPI.Core.DTOs;

namespace PersonalFinanceAPI.API.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAllAsync();
        Task<UserDto> GetByIdAsync(int id);
        Task<int> AddAsync(UserDto userDto);
        Task UpdateAsync(int id, UserDto userDto);
        Task DeleteAsync(int id);
        Task<int> RegisterAsync(UserDto userDto);
        Task<bool> LoginAsync(LoginDto loginDto);
    }
}