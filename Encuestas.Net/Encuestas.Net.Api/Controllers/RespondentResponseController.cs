using Encuestas.Net.Application.Interfaces.Contracts;
using Encuestas.Net.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Encuestas.Net.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RespondentResponseController : Controller
    {
        private readonly IRespondentResponseService _respondentResponseService;
        public RespondentResponseController(IRespondentResponseService respondentResponseService)
        {
			_respondentResponseService = respondentResponseService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var elements = await _respondentResponseService.GetRespondentResponseAsync();

                if (elements == null)
                    return NotFound(new ResultViewModel<RespondentResponseDto>("ERR-NF01 No se encontró ninguna Respuesta"));

                return Ok(new ResultViewModel<IEnumerable<RespondentResponseDto>>(elements));
            }
            catch (Exception exception)
            {
                return StatusCode(500, new ResultViewModel<RespondentResponseDto>(exception.Message));
            }
        }
        [HttpPost]
        public async Task<IActionResult> Insert(RespondentResponseDto data)
        {
            try
            {
                var element = await _respondentResponseService.InsertAsync(data);     
                return Ok(new ResultViewModel<RespondentResponseDto>(element));
            }
            catch (Exception exception)
            {
                return StatusCode(500, new ResultViewModel<RespondentResponseDto>(exception.Message));
            }
        }
    }
}
