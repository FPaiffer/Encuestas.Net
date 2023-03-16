using System.ComponentModel.DataAnnotations;
namespace Encuestas.Net.Domain.Entities
{
	/// <summary>
	/// Survey
	/// </summary>
	/// <seealso cref="Encuestas.Net.Domain.Entities.EntityBase" />
	public class Survey : EntityBase
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		[MaxLength(200)]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>
		/// The description.
		/// </value>
		[MaxLength(500)]
		public string? Description { get; set; }
		/// <summary>
		/// Gets or sets the questions.
		/// </summary>
		/// <value>
		/// The questions.
		/// </value>
		public ICollection<Question> Questions { get; set; }
		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>
		/// The created on.
		/// </value>
		public DateTime CreatedOn { get; set; }
	}
}
