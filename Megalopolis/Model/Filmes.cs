using Megalopolis.Base;

namespace Megalopolis.Model
{
    public class Filmes: BaseModel
    {
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataEncerramento { get; set; }
        public required string Duracao { get; set; }
        public required string Image { get; set; }
    }
}
