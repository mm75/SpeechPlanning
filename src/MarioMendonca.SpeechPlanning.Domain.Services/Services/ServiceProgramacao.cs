using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Domain.Services.Services
{
    public class ServiceProgramacao : ServiceBase<Programacao>, IServiceProgramacao
    {
        public readonly IRepositoryProgramacao _repositoryProgramacao;
        
        public ServiceProgramacao(IRepositoryProgramacao repositoryProgramacao) : base(repositoryProgramacao)
        {
            _repositoryProgramacao = repositoryProgramacao;
        }
    }
}