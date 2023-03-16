using AutoMapper;
using Encuestas.Net.Application.Interfaces.Contracts;
using Encuestas.Net.Domain.Entities;
using Encuestas.Net.Domain.Interfaces.Contracts;
using Encuestas.Net.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestas.Net.Application.Interfaces
{
    public class RespondentService : IRespondentService
    {
        /// <summary>
		/// The mapper
		/// </summary>
		private readonly IMapper _mapper;
        private readonly IRespondentReporsitory _respondentRepository;

		public RespondentService(IMapper mapper, IRespondentReporsitory respondentRepository)
        {
            _mapper = mapper;
            _respondentRepository = respondentRepository;
		}
        public async Task<IEnumerable<RespondentDto>> GetRespondentAsync()
        {
            try
            {
                var Elements = await _respondentRepository.GetAllWithIncludeAsync();
                if (Elements == null || Elements.Count == 0)
                    return null;

                var elementsResult = new List<RespondentDto>();
                foreach (var item in Elements)
                {
                    var itemDto = _mapper.Map<RespondentDto>(item);
                    elementsResult.Add(itemDto);
                }
                return elementsResult;
            }
            catch
            {
                throw new Exception("ERR-02 Falla interna en el servidor");
            }
        }
        public async Task<RespondentDto> InsertAsync(RespondentDto data)
        {
            try
            {
                var Element = _mapper.Map<Respondent>(data);
                Element = await _respondentRepository.InsertAsync(Element);
                return _mapper.Map<RespondentDto>(Element);
            }
            catch (Exception)
            {

                throw new Exception("ERR-03 Falla interna en el servidor");
            }
        }
		
	}
}
