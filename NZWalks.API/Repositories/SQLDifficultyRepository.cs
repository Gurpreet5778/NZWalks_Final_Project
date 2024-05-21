using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class SQLDifficultyRepository : IDifficultyRepository
    {
        private readonly NZWalksDbContext _dbContext;

        public SQLDifficultyRepository(NZWalksDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Difficulty>> GetAllAsync()
        {
           return await _dbContext.Difficulties.ToListAsync();
        }
    }
}