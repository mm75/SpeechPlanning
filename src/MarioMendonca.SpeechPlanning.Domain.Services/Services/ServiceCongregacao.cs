using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Domain.Services.Services
{
    public class ServiceCongregacao : ServiceBase<Congregacao>, IServiceCongregacao
    {
        public readonly IRepositoryCongregacao _RepositoryCongregacao;
        
        public ServiceCongregacao(IRepositoryCongregacao repositoryCongregacao) : base(repositoryCongregacao)
        {
            _RepositoryCongregacao = repositoryCongregacao;
        }
    }
}