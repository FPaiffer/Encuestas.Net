using Encuestas.Net.Models.Dtos;

namespace Encuestas.Net.Presentation.Services.Contracts
{
    public interface IRespondentResponseService
	{
        Task<RespondentResponseDto> InsertAsync(RespondentResponseDto data);
        Task<IEnumerable<RespondentResponseDto>> GetRespondentResponseAsync();
    }
}
