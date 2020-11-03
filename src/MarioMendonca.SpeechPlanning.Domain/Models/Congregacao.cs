namespace MarioMendonca.SpeechPlanning.Domain.Models
{
    public class Congregacao : BaseEntity
    {
        public string Nome { get; set; }
        public bool Local { get; set; }
        public bool Ativo { get; set; }
    }
}