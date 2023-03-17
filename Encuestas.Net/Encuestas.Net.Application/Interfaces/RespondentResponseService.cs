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
    public class RespondentResponseService : IRespondentResponseService
    {
        /// <summary>
		/// The mapper
		/// </summary>
		private readonly IMapper _mapper;
		private readonly IRespondentResponseReporsitory _respondentResponseRepository;

		public RespondentResponseService(IMapper mapper, IRespondentResponseReporsitory respondentResponseRepository)
        {
            _mapper = mapper;
			_respondentResponseRepository= respondentResponseRepository;
		}
        public async Task<IEnumerable<RespondentResponseDto>> GetRespondentResponseAsync()
        {
            try
            {
                var Elements = await _respondentResponseRepository.GetAllAsync();
                if (Elements == null || Elements.Count == 0)
                    return null;

                var elementsResult = new List<RespondentResponseDto>();
                foreach (var item in Elements)
                {
                    var itemDto = _mapper.Map<RespondentResponseDto>(item);
                    elementsResult.Add(itemDto);
                }
                return elementsResult;
            }
            catch
            {
                throw new Exception("ERR-02 Falla interna en el servidor");
            }
        }

		public async Task<IEnumerable<RespondentResponseDto>> GetRespondentResponseByRespondentAsync(int RespondentId)
		{
			try
			{
				var Elements = await _respondentResponseRepository.GetAllByRespondentAsync(RespondentId);
				if (Elements == null || Elements.Count == 0)
					return null;

				var elementsResult = new List<RespondentResponseDto>();
				foreach (var item in Elements)
				{
					var itemDto = _mapper.Map<RespondentResponseDto>(item);
					elementsResult.Add(itemDto);
				}
				return elementsResult;
			}
			catch
			{
				throw new Exception("ERR-02 Falla interna en el servidor");
			}
		}


		public async Task<RespondentResponseDto> InsertAsync(RespondentResponseDto data)
        {
            try
            {
                var Element = _mapper.Map<RespondentResponse>(data);
                Element = await _respondentResponseRepository.InsertAsync(Element);
                return _mapper.Map<RespondentResponseDto>(Element);
            }
            catch (Exception e)
            {
                throw new Exception("ERR-03 Falla interna en el servidor");
            }
        }
    }
}
