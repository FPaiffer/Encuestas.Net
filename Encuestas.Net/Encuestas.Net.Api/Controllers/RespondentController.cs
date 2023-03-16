using Encuestas.Net.Application.Interfaces.Contracts;
using Encuestas.Net.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Encuestas.Net.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RespondentController : Controller
    {
        private readonly IRespondentService _respondentService;
        public RespondentController(IRespondentService respondentService)
        {
            _respondentService = respondentService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var elements = await _respondentService.GetRespondentAsync();

                if (elements == null)
                    return NotFound(new ResultViewModel<RespondentDto>("ERR-NF01 No se encontró ningun Encuestado"));

                return Ok(new ResultViewModel<IEnumerable<RespondentDto>>(elements));
            }
            catch (Exception exception)
            {
                return StatusCode(500, new ResultViewModel<RespondentDto>(exception.Message));
            }
        }
        [HttpPost]
        public async Task<IActionResult> Insert(RespondentDto data)
        {
            try
            {
                var element = await _respondentService.InsertAsync(data);
                return Ok(new ResultViewModel<RespondentDto>(element));
            }
            catch (Exception exception)
            {
                return StatusCode(500, new ResultViewModel<RespondentDto>(exception.Message));
            }
        }
    }
}
