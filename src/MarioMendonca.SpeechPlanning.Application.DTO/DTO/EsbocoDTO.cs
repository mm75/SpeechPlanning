using System;

namespace MarioMendonca.SpeechPlanning.Application.DTO.DTO
{
    public class EsbocoDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Numero { get; set; }
        public string Titulo{ get; set; }
        public Guid IdiomaId{ get; set; }
        public string IdiomaNome { get; set; }
    }
}