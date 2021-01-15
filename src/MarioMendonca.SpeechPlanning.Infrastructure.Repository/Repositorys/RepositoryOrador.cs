using System;
using System.Collections.Generic;
using System.Linq;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

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

        public override Orador GetById(Guid id)
        {
            return _context.Oradores.Include(x => x.Congregacao).FirstOrDefault();
        }

        public override IEnumerable<Orador> GetAll()
        {
            return _context.Oradores.Include(x => x.Congregacao).ToList();
        }

        public IEnumerable<Orador> GetByNome(string nome)
        {
            return _context.Set<Orador>()
                .Where(i => EF.Functions.Like(i.Nome, $"{nome}%"))
                .Include(x => x.Congregacao).ToList();
        }
    }
}