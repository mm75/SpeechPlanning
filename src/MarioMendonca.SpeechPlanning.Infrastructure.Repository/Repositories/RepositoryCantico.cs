using System.Collections.Generic;
using System.Linq;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MarioMendonca.SpeechPlanning.Infrastructure.Repository.Repositories
{
    public class RepositoryCantico : RepositoryBase<Cantico>, IRepositoryCantico
    {
        private readonly SqlContext _context;

        public RepositoryCantico(SqlContext context)
            : base(context)
        {
            _context = context;
        }

        public IEnumerable<Cantico> GetByTitulo(string titulo)
        {
            return _context.Set<Cantico>()
                .Where(i => EF.Functions.Like(i.Titulo, $"{titulo}%"));
        }
    }
}