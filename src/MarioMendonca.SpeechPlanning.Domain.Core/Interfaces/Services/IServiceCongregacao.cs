using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services
{
    public interface IServiceCongregacao : IServiceBase<Congregacao>
    {
        public IEnumerable<Congregacao> GetByNome(string nome);
    }
}