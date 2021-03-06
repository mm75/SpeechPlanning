using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services
{
    public interface IServiceOrador : IServiceBase<Orador>
    {
        public IEnumerable<Orador> GetByNome(string nome);
    }
}