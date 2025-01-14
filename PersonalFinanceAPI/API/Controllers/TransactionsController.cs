using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonalFinanceAPI.API.Services;
using PersonalFinanceAPI.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalFinanceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransactionDto>>> GetTransactions()
        {
            var transactions = await _transactionService.GetAllAsync();
            return Ok(transactions);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TransactionDto>> GetTransaction(int id)
        {
            var transaction = await _transactionService.GetByIdAsync(id);
            if (transaction == null)
                return NotFound();
            return Ok(transaction);
        }

        [HttpPost]
        public async Task<ActionResult> CreateTransaction([FromBody] TransactionDto transactionDto)
        {
            await _transactionService.AddAsync(transactionDto);
            return CreatedAtAction(nameof(GetTransaction), new { id = transactionDto.Id }, transactionDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTransaction(int id, [FromBody] TransactionDto transactionDto)
        {
            await _transactionService.UpdateAsync(id, transactionDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTransaction(int id)
        {
            await _transactionService.DeleteAsync(id);
            return NoContent();
        }
    }
}