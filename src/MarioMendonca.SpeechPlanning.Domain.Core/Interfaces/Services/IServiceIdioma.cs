using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services
{
    public interface IServiceIdioma : IServiceBase<Idioma>
    {
        public IEnumerable<Idioma> GetByNome(string nome);
    }
}