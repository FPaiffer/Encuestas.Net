using Encuestas.Net.Models.Dtos;

namespace Encuestas.Net.Presentation.Services.Contracts
{
    public interface ISurveyService
    {
        Task<IEnumerable<SurveyDto>> GetSurveysAsync();
    }
}
