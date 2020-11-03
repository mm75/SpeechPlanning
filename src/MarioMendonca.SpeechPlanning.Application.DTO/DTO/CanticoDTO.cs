using System;

namespace MarioMendonca.SpeechPlanning.Application.DTO.DTO
{
    public class CanticoDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Numero { get; set; }
        public string Titulo{ get; set; }
    }
}