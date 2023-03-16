
namespace Encuestas.Net.Models.Dtos
{

	public class RespondentResponseDto
	{
        public int Id { get; set; }
        public int RespondentReferenceId { get; set; }
		public RespondentDto RespondentReference { get; set; }
		
		public int SurveyReferenceId { get; set; }
		public SurveyDto SurveyReference { get; set; }
		
		public int QuestionReferenceId { get; set; }
		public QuestionDto QuestionReference { get; set; }

		public int AnswerReferenceId { get; set; }
		public AnswerDto AnswerReference { get; set; }

		public DateTime CreatedOn { get; set; }
	}
}
