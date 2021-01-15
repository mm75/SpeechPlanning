using System.Collections.Generic;
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

        public IEnumerable<Congregacao> GetByNome(string nome)
        {
            return _RepositoryCongregacao.GetByNome(nome);
        }
    }
}