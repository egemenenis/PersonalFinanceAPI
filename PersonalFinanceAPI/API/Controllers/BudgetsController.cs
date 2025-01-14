using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonalFinanceAPI.API.Repositories;
using PersonalFinanceAPI.Core.Entities;

namespace PersonalFinanceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetsController : ControllerBase
    {
        private readonly IBudgetRepository _budgetRepository;

        public BudgetsController(IBudgetRepository budgetRepository)
        {
            _budgetRepository = budgetRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Budget>>> GetBudgets()
        {
            var budgets = await _budgetRepository.GetAllAsync();
            return Ok(budgets);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Budget>> GetBudget(int id)
        {
            var budget = await _budgetRepository.GetByIdAsync(id);
            if (budget == null)
                return NotFound();
            return Ok(budget);
        }

        [HttpPost]
        public async Task<ActionResult> CreateBudget([FromBody] Budget budget)
        {
            await _budgetRepository.AddAsync(budget);
            return CreatedAtAction(nameof(GetBudget), new { id = budget.Id }, budget);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateBudget(int id, [FromBody] Budget budget)
        {
            await _budgetRepository.UpdateAsync(budget);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBudget(int id)
        {
            await _budgetRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}