using Encuestas.Net.Models.Enums;
namespace Encuestas.Net.Models.Dtos
{
	public class QuestionDto
	{
        public int Id { get; set; }
        public string Text { get; set; }
		public DataTypeShow Type { get; set; }
		public SectionDto Section { get; set; }
		public bool IsMultiple { get; set; }
		public ICollection<AnswerDto> Answers { get; set; }
	}
}
