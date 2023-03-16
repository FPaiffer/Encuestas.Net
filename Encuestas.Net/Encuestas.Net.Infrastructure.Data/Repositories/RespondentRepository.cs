using Encuestas.Net.Domain.Entities;
using Encuestas.Net.Domain.Interfaces.Contracts;
using Encuestas.Net.Infrastructure.Data.Contexts;
using Encuestas.Net.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Condomify.Infrastructure.Data.Repositories
{

	public class RespondentRepository : BaseRepository<Respondent>, IRespondentReporsitory
    {
		public RespondentRepository(DataBaseContext context) : base(context)
        {
        }

		public async Task<List<Respondent>> GetAllWithIncludeAsync()
		{
			var result= await Context
				   .Set<Respondent>().ToListAsync();
			return result;
		}
	}
}

