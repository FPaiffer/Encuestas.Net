using Encuestas.Net.Models.Dtos;
using Encuestas.Net.Presentation.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace Encuestas.Net.Presentation.Pages
{
    public class SurveyBase : ComponentBase
    {
        [Inject]
        public ISurveyService SurveyService { get; set; }
        public IEnumerable<SurveyDto> surveys { get; set; }
        public string ErrorMessage { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                surveys = await SurveyService.GetSurveysAsync();
            }
            catch (Exception ex)
            {

            }

        }

    }
}
