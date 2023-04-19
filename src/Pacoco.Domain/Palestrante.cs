using System.Collections.Generic;

namespace Pacoco.Domain
{
    public class Palestrante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string descricao { get; set; }
        public string URLImg { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public IEnumerable<RedeSocial> RedeSocials { get; set; }
    }

}
