using PersonalFinanceAPI.Core.DTOs;
using PersonalFinanceAPI.Core.Entities;
using PersonalFinanceAPI.API.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace PersonalFinanceAPI.API.Services
{
    public class SavingService : ISavingService
    {
        private readonly ISavingRepository _savingRepository;
        private readonly IMapper _mapper;

        public SavingService(ISavingRepository savingRepository, IMapper mapper)
        {
            _savingRepository = savingRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<SavingDto>> GetAllAsync()
        {
            var savings = await _savingRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<SavingDto>>(savings);
        }
        public async Task<SavingDto> GetByIdAsync(int id)
        {
            var saving = await _savingRepository.GetByIdAsync(id);
            return _mapper.Map<SavingDto>(saving);
        }

        public async Task AddAsync(SavingDto savingDto)
        {
            var saving = new Saving
            {
                Name = savingDto.Name,
                Amount = savingDto.Amount,
                DateAdded = savingDto.DateAdded
            };

            await _savingRepository.AddAsync(saving);
        }

        public async Task UpdateAsync(int id, SavingDto savingDto)
        {
            var saving = await _savingRepository.GetByIdAsync(id);
            if (saving != null)
            {
                _mapper.Map(savingDto, saving);
                await _savingRepository.UpdateAsync(saving);
            }
        }
        public async Task DeleteAsync(int id)
        {
            await _savingRepository.DeleteAsync(id);
        }
    }
}