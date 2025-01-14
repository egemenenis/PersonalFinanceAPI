using AutoMapper;
using PersonalFinanceAPI.API.Repositories;
using PersonalFinanceAPI.Core.DTOs;
using PersonalFinanceAPI.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalFinanceAPI.API.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IMapper _mapper;

        public TransactionService(ITransactionRepository transactionRepository, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TransactionDto>> GetAllAsync()
        {
            var transactions = await _transactionRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<TransactionDto>>(transactions);
        }

        public async Task<TransactionDto> GetByIdAsync(int id)
        {
            var transaction = await _transactionRepository.GetByIdAsync(id);
            return _mapper.Map<TransactionDto>(transaction);
        }

        public async Task AddAsync(TransactionDto transactionDto)
        {
            var transaction = _mapper.Map<Transaction>(transactionDto);
            await _transactionRepository.AddAsync(transaction);
        }

        public async Task UpdateAsync(int id, TransactionDto transactionDto)
        {
            var transaction = await _transactionRepository.GetByIdAsync(id);
            if (transaction != null)
            {
                _mapper.Map(transactionDto, transaction);
                await _transactionRepository.UpdateAsync(transaction);
            }
        }

        public async Task DeleteAsync(int id)
        {
            await _transactionRepository.DeleteAsync(id);
        }
    }
}