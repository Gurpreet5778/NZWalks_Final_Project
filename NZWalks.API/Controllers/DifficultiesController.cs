using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DifficultiesController : ControllerBase
    {
        private readonly SQLDifficultyRepository _difficultyRepository;

        public DifficultiesController(SQLDifficultyRepository difficultyRepository)
        {
            _difficultyRepository = difficultyRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            var DifficultyDomain = await _difficultyRepository.GetAllAsync();
            return Ok(DifficultyDomain);
        }
    }
}
