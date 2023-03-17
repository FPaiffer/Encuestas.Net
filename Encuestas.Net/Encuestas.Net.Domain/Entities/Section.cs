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
	public class Section : EntityBase
	{
		/// <summary>
		/// Gets or sets the text.
		/// </summary>
		/// <value>
		/// The text.
		/// </value>
		[MaxLength(200)]
		public string Text { get; set; }

		public ICollection<Question> Questions { get; set; }
	}
}
