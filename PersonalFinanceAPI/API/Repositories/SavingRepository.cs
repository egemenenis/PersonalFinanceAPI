using Microsoft.EntityFrameworkCore;
using PersonalFinanceAPI.Core.Entities;
using PersonalFinanceAPI.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalFinanceAPI.API.Repositories
{
    public class SavingRepository : ISavingRepository
    {
        private readonly ApplicationDbContext _context;

        public SavingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Saving>> GetAllAsync()
        {
            return await _context.Savings.ToListAsync();
        }

        public async Task<Saving> GetByIdAsync(int id)
        {
            return await _context.Savings.FindAsync(id);
        }

        public async Task AddAsync(Saving saving)
        {
            await _context.Savings.AddAsync(saving);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Saving saving)
        {
            _context.Savings.Update(saving);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var saving = await _context.Savings.FindAsync(id);
            if (saving != null)
            {
                _context.Savings.Remove(saving);
                await _context.SaveChangesAsync();
            }
        }
    }
}