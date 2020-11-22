using System.Collections.Generic;

namespace MarioMendonca.SpeechPlanning.Domain.Models
{
    public class Idioma : BaseEntity
    {
        public string Nome { get; set; }
        
        public List<Esboco> Esbocos { get; set; }
    }
}