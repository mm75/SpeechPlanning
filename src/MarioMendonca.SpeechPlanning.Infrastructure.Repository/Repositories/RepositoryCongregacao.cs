using System.Collections.Generic;
using System.Linq;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MarioMendonca.SpeechPlanning.Infrastructure.Repository.Repositories
{
    public class RepositoryCongregacao : RepositoryBase<Congregacao>, IRepositoryCongregacao
    {
        private readonly SqlContext _context;

        public RepositoryCongregacao(SqlContext context)
            : base(context)
        {
            _context = context;
        }

        public IEnumerable<Congregacao> GetByNome(string nome)
        {
            return _context.Set<Congregacao>()
                .Where(i => EF.Functions.Like(i.Nome, $"{nome}%"));
        }
    }
}