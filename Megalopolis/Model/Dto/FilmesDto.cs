namespace Megalopolis.Model.Dto
{
    public class FilmesDto
    {
        public Guid Id { get; set; }
        public string Image { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataEncerramento { get; set; }
        public string Duracao { get; set; }
    }
}
