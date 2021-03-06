namespace MarioMendonca.SpeechPlanning.Domain.Models
{
    public class Cantico : BaseEntity
    {
        public int Numero { get; set; }
        public string Titulo{ get; set; }
        public int IdiomaId { get; set; }
        public virtual Idioma Idioma { get; set; }
    }
}