using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.Data;

namespace MarioMendonca.SpeechPlanning.Infrastructure.Repository.Repositorys
{
    public class RepositoryOrador : RepositoryBase<Orador>, IRepositoryOrador
    {
        private readonly SqlContext _context;

        public RepositoryOrador(SqlContext context)
            : base(context)
        {
            _context = context;
        }
    }
}