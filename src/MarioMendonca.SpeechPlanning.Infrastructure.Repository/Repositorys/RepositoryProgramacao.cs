using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.Data;

namespace MarioMendonca.SpeechPlanning.Infrastructure.Repository.Repositorys
{
    public class RepositoryProgramacao : RepositoryBase<Programacao>, IRepositoryProgramacao
    {
        private readonly SqlContext _context;

        public RepositoryProgramacao(SqlContext context)
            : base(context)
        {
            _context = context;
        }
    }
}