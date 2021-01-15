using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryCantico : IRepositoryBase<Cantico>
    {
        public IEnumerable<Cantico> GetByTitulo(string titulo);
    }
}