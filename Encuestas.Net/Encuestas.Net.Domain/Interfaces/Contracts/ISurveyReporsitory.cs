using Encuestas.Net.Domain.Entities;

namespace Encuestas.Net.Domain.Interfaces.Contracts
{
	public interface ISurveyReporsitory : IBaseRepository<Survey>
	{
		Task<List<Survey>> GetAllWithIncludeAsync();
	}
}
