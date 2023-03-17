using AutoMapper;
using Encuestas.Net.Domain.Entities;
using Encuestas.Net.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestas.Net.Applications.Mappings
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
			#region Maping Survey         
			CreateMap<Survey, SurveyDto>();
			#endregion
			#region Maping SurveyDto         
			CreateMap<SurveyDto, Survey>();
			#endregion
			#region Maping Section         
			CreateMap<Section, SectionDto>();
			#endregion
			#region Maping SectionDto         
			CreateMap<SectionDto, Section>().ForMember(a=>a.Questions, opt => opt.Ignore());
			#endregion
			#region Maping Question         
			CreateMap<Question, QuestionDto>();
			#endregion
			#region Maping QuestionDto         
			CreateMap<QuestionDto, Question>();
			#endregion
			#region Maping Answer         
			CreateMap<Answer, AnswerDto>();
			#endregion
			#region Maping AnswerDto         
			CreateMap<AnswerDto, Answer>();
			#endregion
			#region Maping Respondent         
			CreateMap<Respondent, RespondentDto>();
            #endregion
            #region Maping RespondentDto         
            CreateMap<RespondentDto, Respondent>();
			#endregion
			#region Maping RespondentResponse         
			CreateMap<RespondentResponse, RespondentResponseDto>();
			#endregion
			#region Maping RespondentResponseDto         
			CreateMap<RespondentResponseDto, RespondentResponse>().ForMember(a=>a.RespondentReference,opt=>opt.Ignore()).ForMember(a => a.SurveyReference, opt => opt.Ignore());
			#endregion
		}

	}
}
