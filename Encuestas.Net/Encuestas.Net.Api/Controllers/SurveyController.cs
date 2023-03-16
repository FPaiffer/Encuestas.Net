using Encuestas.Net.Application.Interfaces.Contracts;
using Encuestas.Net.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Encuestas.Net.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : Controller
    {
        private readonly ISurveyService _surveyService;
        public SurveyController(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var elements = await _surveyService.GetSurveysAsync();

                if (elements == null)
                    return NotFound(new ResultViewModel<SurveyDto>("ERR-NF01 No se encontró ninguna Encuesta"));

                return Ok(new ResultViewModel<IEnumerable<SurveyDto>>(elements));
            }
            catch (Exception exception)
            {
                return StatusCode(500, new ResultViewModel<SurveyDto>(exception.Message));
            }
        }
    }
}
