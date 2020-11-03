using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.Data;

namespace MarioMendonca.SpeechPlanning.Infrastructure.Repository.Repositorys
{
    public class RepositoryCongregacao : RepositoryBase<Congregacao>, IRepositoryCongregacao
    {
        private readonly SqlContext _context;

        public RepositoryCongregacao(SqlContext context)
            : base(context)
        {
            _context = context;
        }
    }
}