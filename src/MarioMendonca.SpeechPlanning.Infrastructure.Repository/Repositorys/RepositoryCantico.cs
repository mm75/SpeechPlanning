using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.Data;

namespace MarioMendonca.SpeechPlanning.Infrastructure.Repository.Repositorys
{
    public class RepositoryCantico : RepositoryBase<Cantico>, IRepositoryCantico
    {
        private readonly SqlContext _context;

        public RepositoryCantico(SqlContext context)
            : base(context)
        {
            _context = context;
        }
    }
}