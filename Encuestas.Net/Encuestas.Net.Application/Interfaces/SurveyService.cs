using AutoMapper;
using Encuestas.Net.Application.Interfaces.Contracts;
using Encuestas.Net.Domain.Interfaces.Contracts;
using Encuestas.Net.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestas.Net.Application.Interfaces
{
    public class SurveyService : ISurveyService
    {
        /// <summary>
		/// The mapper
		/// </summary>
		private readonly IMapper _mapper;

        private readonly ISurveyReporsitory _surveyRepository;

        public SurveyService(IMapper mapper, ISurveyReporsitory surveyRepository)
        {
            _mapper = mapper;
            _surveyRepository = surveyRepository;
        }
        public async Task<IEnumerable<SurveyDto>> GetSurveysAsync()
        {
            try
            {
                var Elements = await _surveyRepository.GetAllWithIncludeAsync();

                if (Elements == null || Elements.Count == 0)
                    return null;

                var elementsResult = new List<SurveyDto>();

                foreach (var item in Elements)
                {
                    var itemDto = _mapper.Map<SurveyDto>(item);
                    elementsResult.Add(itemDto);
                }
                return elementsResult;
            }
            catch
            {
                throw new Exception("ERR-01 Falla interna en el servidor");
            }
        }
    }
}
