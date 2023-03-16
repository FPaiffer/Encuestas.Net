using Encuestas.Net.Models.Dtos;
using Encuestas.Net.Presentation.Services.Contracts;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace Encuestas.Net.Presentation.Services
{
    public class SurveyService : ISurveyService
    {
        private readonly HttpClient httpClient;

        public SurveyService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<SurveyDto>> GetSurveysAsync()
        {
            try
            {
                var response = await this.httpClient.GetAsync("api/Survey");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(IEnumerable<SurveyDto>);
                    }
                    var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var obj = JsonConvert.DeserializeObject<ResultViewModel<IEnumerable<SurveyDto>>>(json);
                    return obj.Data.ToList();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status code: {response.StatusCode} message: {message}");
                }

            }
            catch (Exception e)
            {
                //Log exception
                throw;
            }
        }
    }
}
