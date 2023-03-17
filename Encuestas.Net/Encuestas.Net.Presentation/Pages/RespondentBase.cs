using Encuestas.Net.Models.Dtos;
using Encuestas.Net.Presentation.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace Encuestas.Net.Presentation.Pages
{
    public class RespondentBase : ComponentBase
    {
        [Inject]
        public IRespondentService respondentService { get; set; }
        public IEnumerable<RespondentDto> respondents { get; set; }
        public string ErrorMessage { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                respondents = await respondentService.GetRespondentAsync();
            }
            catch (Exception ex)
            {

            }

        }

    }
}
