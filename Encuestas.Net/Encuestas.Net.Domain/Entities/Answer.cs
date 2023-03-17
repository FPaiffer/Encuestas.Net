using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestas.Net.Domain.Entities
{
	/// <summary>
	/// Answer
	/// </summary>
	/// <seealso cref="Encuestas.Net.Domain.Entities.EntityBase" />
	public class Answer : EntityBase
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
		/// Gets or sets the question go to.
		/// </summary>
		/// <value>
		/// The question go to.
		/// </value>
		public int? QuestionGoTo { get; set; }

		public Question QuestionOwner { get; set; }
	}
}
