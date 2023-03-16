using Encuestas.Net.Models.Dtos;
using Encuestas.Net.Presentation.Services.Contracts;
using Newtonsoft.Json;
using System;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace Encuestas.Net.Presentation.Services
{
    public class RespondentResponseService : IRespondentResponseService
    {
        private readonly HttpClient httpClient;

        public RespondentResponseService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<RespondentResponseDto>> GetRespondentResponseAsync()
        {
            try
            {
                var response = await this.httpClient.GetAsync("api/RespondentResponse");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(IEnumerable<RespondentResponseDto>);
                    }
                    var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var obj = JsonConvert.DeserializeObject<ResultViewModel<IEnumerable<RespondentResponseDto>>>(json);
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

		public async Task<IEnumerable<RespondentResponseDto>> GetRespondentResponseByRespondentAsync(int RespondentId)
		{
			try
			{
				var response = await this.httpClient.GetAsync("api/RespondentResponse/"+ RespondentId);

				if (response.IsSuccessStatusCode)
				{
					if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
					{
						return default(IEnumerable<RespondentResponseDto>);
					}
					var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
					var obj = JsonConvert.DeserializeObject<ResultViewModel<IEnumerable<RespondentResponseDto>>>(json);
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

		public async Task<RespondentResponseDto> InsertAsync(RespondentResponseDto data)
        {
            try
            {
                String output = JsonConvert.SerializeObject(data);
                StringContent content = new StringContent(output, Encoding.UTF8, "application/json");
                var response = await this.httpClient.PostAsync("api/RespondentResponse", content);

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(RespondentResponseDto);
                    }
                    var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var obj = JsonConvert.DeserializeObject<ResultViewModel<RespondentResponseDto>>(json);
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
