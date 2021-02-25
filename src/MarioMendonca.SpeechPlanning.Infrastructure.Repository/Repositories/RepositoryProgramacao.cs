using System;
using System.Collections.Generic;
using System.Linq;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MarioMendonca.SpeechPlanning.Infrastructure.Repository.Repositories
{
    public class RepositoryProgramacao : RepositoryBase<Programacao>, IRepositoryProgramacao
    {
        private readonly SqlContext _context;

        public RepositoryProgramacao(SqlContext context)
            : base(context)
        {
            _context = context;
        }
        
        public override Programacao GetById(Guid id)
        {
            return _context.Programacoes
                .Include(x => x.Congregacao)
                .Include(x => x.Orador)
                .Include(x => x.Esboco)
                .Include(x => x.Cantico)
                .FirstOrDefault();
        }

        public override IEnumerable<Programacao> GetAll()
        {
            return _context.Programacoes
                .Include(x => x.Congregacao)
                .Include(x => x.Orador)
                .Include(x => x.Esboco)
                .Include(x => x.Cantico)
                .ToList();
        }
    }
}