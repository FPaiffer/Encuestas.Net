using Encuestas.Net.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestas.Net.Domain.Entities
{
	/// <summary>
	/// Question
	/// </summary>
	/// <seealso cref="Encuestas.Net.Domain.Entities.EntityBase" />
	public class Question :EntityBase
	{
		/// <summary>
		/// Gets or sets the text.
		/// </summary>
		/// <value>
		/// The text.
		/// </value>
		[MaxLength(200)]
		public string Text { get; set; }

		/// <summary>
		/// Gets or sets the question father.
		/// </summary>
		/// <value>
		/// The question father.
		/// </value>
		public Question? QuestionFather { get; set; }
		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>
		/// The type.
		/// </value>
		public DataTypeShow Type { get; set; }
		public bool IsMultiple { get; set; }
		/// <summary>
		/// Gets or sets the answers.
		/// </summary>
		/// <value>
		/// The answers.
		/// </value>
		public Section Section { get; set; }
		public ICollection<Answer> Answers { get; set; }
	}
}
