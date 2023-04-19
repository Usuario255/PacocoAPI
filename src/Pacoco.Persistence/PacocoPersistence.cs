using System.Threading.Tasks;
using Pacoco.Domain;

namespace Pacoco.Persistence
{
    public class PacocoPersistence : IPacocoPersistence
    {
        private readonly DataContext _context;

        public PacocoPersistence(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
         public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(T[] entity) where T : class
        {
            _context.RemoveRange(entity);
        }
         public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync())> 0;
        }
        public Task<Evento[]> GetAllEventoByIdAsync(int EventoId, bool includPalestrantes)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosAsync(string tema, bool includPalestrantes)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosByTemasAsync(string tema, bool includPalestrantes)
        {
            throw new System.NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestranteByIdAsync(int PalestranteId, bool includEventos)
        {
            throw new System.NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesAsync(string nome, bool includEventos)
        {
            throw new System.NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includEventos)
        {
            throw new System.NotImplementedException();
        }       
    }
}