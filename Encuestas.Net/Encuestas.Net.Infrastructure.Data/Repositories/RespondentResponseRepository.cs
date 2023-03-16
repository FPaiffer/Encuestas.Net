using Encuestas.Net.Domain.Entities;
using Encuestas.Net.Domain.Interfaces.Contracts;
using Encuestas.Net.Infrastructure.Data.Contexts;
using Encuestas.Net.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Condomify.Infrastructure.Data.Repositories
{

	public class RespondentResponseRepository : BaseRepository<RespondentResponse>, IRespondentResponseReporsitory
    {
		public RespondentResponseRepository(DataBaseContext context) : base(context)
        {
        }

		public async Task<List<RespondentResponse>> GetAllByRespondentAsync(int RespondentId)
		{
			var result = await Context
			   .Set<RespondentResponse>()
			   .Where(a=>a.RespondentReferenceId== RespondentId)
			   .Include(s=>s.SurveyReference)
			   .ThenInclude(q=>q.Sections)
			   .ThenInclude(a=>a.Questions)
			   .ThenInclude(a => a.Answers)
			   .ToListAsync();
			return result;
		}

		public async Task<List<RespondentResponse>> GetAllWithIncludeAsync()
		{
			var result= await Context
				   .Set<RespondentResponse>().ToListAsync();
			return result;
		}
	}
}

