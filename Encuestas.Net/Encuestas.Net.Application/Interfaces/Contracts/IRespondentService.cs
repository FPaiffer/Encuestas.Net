using Encuestas.Net.Domain.Entities;
using Encuestas.Net.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestas.Net.Application.Interfaces.Contracts
{
    public interface IRespondentService
    {
        Task<RespondentDto> InsertAsync(RespondentDto data);
        Task<IEnumerable<RespondentDto>> GetRespondentAsync();
    }
}
