using Microsoft.EntityFrameworkCore;
using PersonalFinanceAPI.Core.Entities;
using PersonalFinanceAPI.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalFinanceAPI.API.Repositories
{
    public class TransactionCategoryRepository : ITransactionCategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public TransactionCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TransactionCategory>> GetAllAsync()
        {
            return await _context.TransactionCategories.ToListAsync();
        }

        public async Task<TransactionCategory> GetByIdAsync(int id)
        {
            return await _context.TransactionCategories.FindAsync(id);
        }

        public async Task AddAsync(TransactionCategory category)
        {
            await _context.TransactionCategories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TransactionCategory category)
        {
            _context.TransactionCategories.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var category = await _context.TransactionCategories.FindAsync(id);
            if (category != null)
            {
                _context.TransactionCategories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }
    }
}