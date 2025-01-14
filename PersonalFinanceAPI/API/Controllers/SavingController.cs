using Microsoft.AspNetCore.Mvc;
using PersonalFinanceAPI.API.Services;
using PersonalFinanceAPI.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalFinanceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavingController : ControllerBase
    {
        private readonly ISavingService _savingService;

        public SavingController(ISavingService savingService)
        {
            _savingService = savingService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SavingDto>>> GetSavings()
        {
            var savings = await _savingService.GetAllAsync();
            return Ok(savings);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SavingDto>> GetSaving(int id)
        {
            var saving = await _savingService.GetByIdAsync(id);
            if (saving == null)
                return NotFound();
            return Ok(saving);
        }

        [HttpPost]
        public async Task<ActionResult> CreateSaving([FromBody] SavingDto savingDto)
        {
            await _savingService.AddAsync(savingDto);
            return CreatedAtAction(nameof(GetSaving), new { id = savingDto.Id }, savingDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateSaving(int id, [FromBody] SavingDto savingDto)
        {
            await _savingService.UpdateAsync(id, savingDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSaving(int id)
        {
            await _savingService.DeleteAsync(id);
            return NoContent();
        }
    }
}