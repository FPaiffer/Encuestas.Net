using Encuestas.Net.Models.Dtos;
using Encuestas.Net.Presentation.Services.Contracts;
using Newtonsoft.Json;
using System;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace Encuestas.Net.Presentation.Services
{
    public class RespondentService : IRespondentService
    {
        private readonly HttpClient httpClient;

        public RespondentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<RespondentDto>> GetRespondentAsync()
        {
            try
            {
                var response = await this.httpClient.GetAsync("api/Respondent");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(IEnumerable<RespondentDto>);
                    }
                    var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var obj = JsonConvert.DeserializeObject<ResultViewModel<IEnumerable<RespondentDto>>>(json);
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

        public async Task<RespondentDto> InsertAsync(RespondentDto data)
        {
            try
            {
                String output = JsonConvert.SerializeObject(data);
                StringContent content = new StringContent(output, Encoding.UTF8, "application/json");
                var response = await this.httpClient.PostAsync("api/Respondent", content);

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(RespondentDto);
                    }
                    var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var obj = JsonConvert.DeserializeObject<ResultViewModel<RespondentDto>>(json);
                    return obj.Data;
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
