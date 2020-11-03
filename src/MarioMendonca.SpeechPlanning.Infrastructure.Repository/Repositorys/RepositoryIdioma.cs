using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.Data;

namespace MarioMendonca.SpeechPlanning.Infrastructure.Repository.Repositorys
{
    public class RepositoryIdioma : RepositoryBase<Idioma>, IRepositoryIdioma
    {
        private readonly SqlContext _context;

        public RepositoryIdioma(SqlContext context)
            : base(context)
        {
            _context = context;
        }
    }
}