using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services
{
    public interface IServiceCantico : IServiceBase<Cantico>
    {
        public IEnumerable<Cantico> GetByTitulo(string nome);
    }
}