using AutoMapper;
using PersonalFinanceAPI.API.Repositories;
using PersonalFinanceAPI.Core.DTOs;
using PersonalFinanceAPI.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace PersonalFinanceAPI.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDto>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<UserDto>>(users);
        }

        public async Task<UserDto> GetByIdAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserDto>(user);
        }

        public async Task<int> AddAsync(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _userRepository.AddAsync(user);
            return user.Id;
        }

        public async Task UpdateAsync(int id, UserDto userDto)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user != null)
            {
                _mapper.Map(userDto, user);
                await _userRepository.UpdateAsync(user);
            }
        }

        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<int> RegisterAsync(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);

            user.Password = HashPassword(user.Password);

            await _userRepository.AddAsync(user);
            return user.Id;
        }

        public async Task<bool> LoginAsync(LoginDto loginDto)
        {
            var user = await _userRepository.GetByEmailAsync(loginDto.Email);

            if (user == null || !VerifyPassword(user.Password, loginDto.Password))
            {
                return false;
            }

            return true;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        private bool VerifyPassword(string storedPassword, string enteredPassword)
        {
            var hashedEnteredPassword = HashPassword(enteredPassword);
            return storedPassword == hashedEnteredPassword;
        }
    }
}