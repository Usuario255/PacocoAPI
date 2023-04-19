using Microsoft.EntityFrameworkCore;
using Pacoco.Domain;

namespace Pacoco.Persistence
{
    public class DataContext : DbContext
    {
        // Criação das tabelas (Sempre em maiusculo)
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<Palestrante> Palestrantes { get; set; }
        public DbSet<RedeSocial> RedeSoscials { get; set; }
        public DbSet<PalestranteEvento> PalestranteEventos { get; set; }

        // toda vez que tiver um atabela de relação devemos declarar as FK dentro dessa função OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PalestranteEvento>()
                .HasKey(PE => new { PE.EventoId, PE.PalestranteId });
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}