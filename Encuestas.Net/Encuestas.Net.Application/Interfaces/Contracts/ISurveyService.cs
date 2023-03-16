using Encuestas.Net.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestas.Net.Application.Interfaces.Contracts
{
    public interface ISurveyService
    {
        Task<IEnumerable<SurveyDto>> GetSurveysAsync();
    }
}
