using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.Data;

namespace MarioMendonca.SpeechPlanning.Infrastructure.Repository.Repositorys
{
    public class RepositoryEsboco : RepositoryBase<Esboco>, IRepositoryEsboco
    {
        private readonly SqlContext _context;

        public RepositoryEsboco(SqlContext context)
            : base(context)
        {
            _context = context;
        }
    }
}