using Encuestas.Net.Domain.Entities;

namespace Encuestas.Net.Domain.Interfaces.Contracts
{
    public interface IRespondentResponseReporsitory : IBaseRepository<RespondentResponse>
	{
		Task<List<RespondentResponse>> GetAllWithIncludeAsync();
		Task<List<RespondentResponse>> GetAllByRespondentAsync(int RespondentId);
	}
}
