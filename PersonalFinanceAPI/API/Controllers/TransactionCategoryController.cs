using Microsoft.AspNetCore.Mvc;
using PersonalFinanceAPI.API.Services;
using PersonalFinanceAPI.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalFinanceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionCategoryController : ControllerBase
    {
        private readonly ITransactionCategoryService _categoryService;

        public TransactionCategoryController(ITransactionCategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransactionCategoryDto>>> GetTransactionCategories()
        {
            var categories = await _categoryService.GetAllAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TransactionCategoryDto>> GetTransactionCategory(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null)
                return NotFound();
            return Ok(category);
        }

        [HttpPost]
        public async Task<ActionResult> CreateTransactionCategory([FromBody] TransactionCategoryDto categoryDto)
        {
            var categoryId = await _categoryService.AddAsync(categoryDto);
            return CreatedAtAction(nameof(GetTransactionCategory), new { id = categoryId }, categoryDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTransactionCategory(int id, [FromBody] TransactionCategoryDto categoryDto)
        {
            await _categoryService.UpdateAsync(id, categoryDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTransactionCategory(int id)
        {
            await _categoryService.DeleteAsync(id);
            return NoContent();
        }
    }
}