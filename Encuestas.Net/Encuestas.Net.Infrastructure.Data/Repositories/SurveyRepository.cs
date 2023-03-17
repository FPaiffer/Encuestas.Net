using Encuestas.Net.Domain.Entities;
using Encuestas.Net.Domain.Interfaces.Contracts;
using Encuestas.Net.Infrastructure.Data.Contexts;
using Encuestas.Net.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Condomify.Infrastructure.Data.Repositories
{

	public class SurveyRepository : BaseRepository<Survey>, ISurveyReporsitory
    {
		public SurveyRepository(DataBaseContext context) : base(context)
        {
        }

		public async Task<List<Survey>> GetAllWithIncludeAsync()
		{
			var result= await Context
				   .Set<Survey>()
				   .Include(q => q.Questions)
				   .ThenInclude(a => a.Answers)
					.Include(q => q.Questions).ThenInclude(a => a.Section)
				   .ToListAsync();
			return result;
		}
	}
}

