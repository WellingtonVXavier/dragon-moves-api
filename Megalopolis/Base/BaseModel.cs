namespace Megalopolis.Base
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsAtivo { get; set; } = true;
    }
}
