using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services
{
    public interface IServiceEsboco : IServiceBase<Esboco>
    {
        public IEnumerable<Esboco> GetByTitulo(string titulo);
    }
}