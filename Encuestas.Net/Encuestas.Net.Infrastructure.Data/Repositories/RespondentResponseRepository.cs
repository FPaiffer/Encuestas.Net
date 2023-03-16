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

		public async Task<List<RespondentResponse>> GetAllWithIncludeAsync()
		{
			var result= await Context
				   .Set<RespondentResponse>().ToListAsync();
			return result;
		}
	}
}

