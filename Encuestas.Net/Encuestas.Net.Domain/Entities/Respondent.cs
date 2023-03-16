using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestas.Net.Domain.Entities
{
	/// <summary>
	/// Respondent
	/// </summary>
	/// <seealso cref="Encuestas.Net.Domain.Entities.EntityBase" />
	public class Respondent : EntityBase
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		[MaxLength(100)]
		public string Name { get; set; }
	}
}
