using System;

namespace MarioMendonca.SpeechPlanning.Application.DTO.DTO
{
    public class IdiomaDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
    }
}