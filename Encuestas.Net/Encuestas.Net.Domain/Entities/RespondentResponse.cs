using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestas.Net.Domain.Entities
{

	/// <summary>
	/// RespondentResponse
	/// </summary>
	/// <seealso cref="Encuestas.Net.Domain.Entities.EntityBase" />
	public class RespondentResponse : EntityBase
	{
		/// <summary>
		/// Gets or sets the respondent reference.
		/// </summary>
		/// <value>
		/// The respondent reference.
		/// </value>
		[Key, Column(Order = 1)]
		public int RespondentReferenceId { get; set; }
		public Respondent RespondentReference { get; set; }
		/// <summary>
		/// Gets or sets the survey reference.
		/// </summary>
		/// <value>
		/// The survey reference.
		/// </value>
		[Key, Column(Order = 2)]
		public int SurveyReferenceId { get; set; }
		public Survey SurveyReference { get; set; }
		/// <summary>
		/// Gets or sets the question reference.
		/// </summary>
		/// <value>
		/// The question reference.
		/// </value>
		[Key, Column(Order = 3)]
		public int QuestionReferenceId { get; set; }
		/// <summary>
		/// Gets or sets the answer reference.
		/// </summary>
		/// <value>
		/// The answer reference.
		/// </value>
		[Key, Column(Order = 4)]
		public int AnswerReferenceId { get; set; }
		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>
		/// The created on.
		/// </value>
		public DateTime CreatedOn { get; set; }
	}
}
