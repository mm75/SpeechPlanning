using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryEsboco : IRepositoryBase<Esboco>
    {
        public IEnumerable<Esboco> GetByTitulo(string titulo);
    }
}