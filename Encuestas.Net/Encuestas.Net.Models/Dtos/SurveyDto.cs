namespace Encuestas.Net.Models.Dtos
{
	public class SurveyDto 
	{
        public int Id { get; set; }
        public string Name { get; set; }
		public string? Description { get; set; }		
		public ICollection<QuestionDto> Questions { get; set; }
		public DateTime CreatedOn { get; set; }
	}
}
