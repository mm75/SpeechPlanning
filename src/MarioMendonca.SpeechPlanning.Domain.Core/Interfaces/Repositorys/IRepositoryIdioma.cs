using System.Collections.Generic;
using System.Linq;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryIdioma : IRepositoryBase<Idioma>
    {
        public IEnumerable<Idioma> GetByNome(string nome);
    }
}