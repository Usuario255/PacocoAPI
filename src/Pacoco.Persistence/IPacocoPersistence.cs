using System.Threading.Tasks;
using Pacoco.Domain;

namespace Pacoco.Persistence
{
    public interface IPacocoPersistence
    {
        //GERAL
        void Add<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        void DeleteRange<T>(T[] entity) where T: class;
        Task<bool> SaveChangesAsync();
        //EVENTOS

        Task<Evento[]> GetAllEventosByTemasAsync(string tema,bool includPalestrantes);
        Task<Evento[]> GetAllEventosAsync(string tema, bool includPalestrantes);
        Task<Evento[]> GetAllEventoByIdAsync(int EventoId,bool includPalestrantes);

        //PALESTRANTES
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome,bool includEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync(string nome, bool includEventos);
        Task<Palestrante[]> GetAllPalestranteByIdAsync(int PalestranteId,bool includEventos);

    }


}