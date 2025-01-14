using AutoMapper;
using PersonalFinanceAPI.API.Repositories;
using PersonalFinanceAPI.Core.DTOs;
using PersonalFinanceAPI.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalFinanceAPI.API.Services
{
    public class TransactionCategoryService : ITransactionCategoryService
    {
        private readonly ITransactionCategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public TransactionCategoryService(ITransactionCategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TransactionCategoryDto>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<TransactionCategoryDto>>(categories);
        }

        public async Task<TransactionCategoryDto> GetByIdAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            return _mapper.Map<TransactionCategoryDto>(category);
        }

        public async Task<int> AddAsync(TransactionCategoryDto categoryDto)
        {
            var category = _mapper.Map<TransactionCategory>(categoryDto);
            await _categoryRepository.AddAsync(category);
            return category.Id;
        }

        public async Task UpdateAsync(int id, TransactionCategoryDto categoryDto)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category != null)
            {
                _mapper.Map(categoryDto, category);
                await _categoryRepository.UpdateAsync(category);
            }
        }
        public async Task DeleteAsync(int id)
        {
            await _categoryRepository.DeleteAsync(id);
        }
    }
}