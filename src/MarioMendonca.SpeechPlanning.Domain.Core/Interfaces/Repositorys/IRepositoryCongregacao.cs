using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryCongregacao : IRepositoryBase<Congregacao>
    {
        public IEnumerable<Congregacao> GetByNome(string nome);
    }
}