using Encuestas.Net.Domain.Entities;

namespace Encuestas.Net.Domain.Interfaces.Contracts
{
    public interface IRespondentReporsitory : IBaseRepository<Respondent>
	{
        Task<List<Respondent>> GetAllWithIncludeAsync();
    }
}
