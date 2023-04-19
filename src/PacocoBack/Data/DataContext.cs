using Microsoft.EntityFrameworkCore;
using Pacoco.Domain;

namespace Back.src.Pacoco.Data.DataContext
{
    public class DataContext : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}