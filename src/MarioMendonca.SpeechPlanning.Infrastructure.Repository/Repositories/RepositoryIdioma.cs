using System.Collections.Generic;
using System.Linq;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MarioMendonca.SpeechPlanning.Infrastructure.Repository.Repositories
{
    public class RepositoryIdioma : RepositoryBase<Idioma>, IRepositoryIdioma
    {
        private readonly SqlContext _context;

        public RepositoryIdioma(SqlContext context)
            : base(context)
        {
            _context = context;
        }

        public virtual IEnumerable<Idioma> GetByNome(string nome)
        {
            return _context.Set<Idioma>()
                .Where(i => EF.Functions.Like(i.Nome, $"{nome}%"));
        }
    }
}