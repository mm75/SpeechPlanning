using System;
using System.Linq;
using MarioMendonca.SpeechPlanning.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MarioMendonca.SpeechPlanning.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
            
        }
        
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Cantico> Canticos { get; set; }
        public DbSet<Congregacao> Congregacoes { get; set; }
        public DbSet<Esboco> Esbocos { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<Orador> Oradores { get; set; }
        public DbSet<Programacao> Programacoes { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Esboco>()
                .HasOne(e => e.Idioma)
                .WithMany(i => i.Esbocos)
                .HasForeignKey(e => e.IdiomaId);
            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlContext).Assembly);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}