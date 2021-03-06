using System;
using System.Collections.Generic;
using System.Linq;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MarioMendonca.SpeechPlanning.Infrastructure.Repository.Repositories
{
    public class RepositoryEsboco : RepositoryBase<Esboco>, IRepositoryEsboco
    {
        private readonly SqlContext _context;

        public RepositoryEsboco(SqlContext context)
            : base(context)
        {
            _context = context;
        }

        public override Esboco GetById(Guid id)
        {
            return _context.Esbocos.Include(x => x.Idioma).FirstOrDefault();
        }

        public override IEnumerable<Esboco> GetAll()
        {
            return _context.Esbocos.Include(x => x.Idioma).ToList();
        }

        public IEnumerable<Esboco> GetByTitulo(string titulo)
        {
            return _context.Set<Esboco>()
                .Where(i => EF.Functions.Like(i.Titulo, $"{titulo}%"))
                .Include(x => x.Idioma).ToList();
        }
    }
}