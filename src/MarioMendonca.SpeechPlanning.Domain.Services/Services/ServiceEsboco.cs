using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Domain.Services.Services
{
    public class ServiceEsboco : ServiceBase<Esboco>, IServiceEsboco
    {
        public readonly IRepositoryEsboco _RepositoryEsboco;
        
        public ServiceEsboco(IRepositoryEsboco repositoryEsboco) : base(repositoryEsboco)
        {
            _RepositoryEsboco = repositoryEsboco;
        }

        public IEnumerable<Esboco> GetByTitulo(string titulo)
        {
            return _RepositoryEsboco.GetByTitulo(titulo);
        }
    }
}