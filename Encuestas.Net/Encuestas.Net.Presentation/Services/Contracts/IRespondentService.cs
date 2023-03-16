using Encuestas.Net.Models.Dtos;

namespace Encuestas.Net.Presentation.Services.Contracts
{
    public interface IRespondentService
    {
        Task<RespondentDto> InsertAsync(RespondentDto data);
        Task<IEnumerable<RespondentDto>> GetRespondentAsync();
    }
}
