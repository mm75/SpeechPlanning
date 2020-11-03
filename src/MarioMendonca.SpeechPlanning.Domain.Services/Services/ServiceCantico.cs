using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Domain.Services.Services
{
    public class ServiceCantico : ServiceBase<Cantico>, IServiceCantico
    {
        public readonly IRepositoryCantico _RepositoryCantico;
        
        public ServiceCantico(IRepositoryCantico repositoryCantico) : base(repositoryCantico)
        {
            _RepositoryCantico = repositoryCantico;
        }
    }
}