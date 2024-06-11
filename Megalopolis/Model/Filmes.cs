using Megalopolis.Base;

namespace Megalopolis.Model
{
    public class Filmes: BaseModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataEncerramento { get; set; }
        public string Duracao { get; set; }
        public string image { get; set; }
    }
}
