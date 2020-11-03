using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Domain.Services.Services
{
    public class ServiceOrador: ServiceBase<Orador>, IServiceOrador
    {
        public readonly IRepositoryOrador _RepositoryOrador;
        
        public ServiceOrador(IRepositoryOrador repositoryOrador) : base(repositoryOrador)
        {
            _RepositoryOrador = repositoryOrador;
        }
    }
}