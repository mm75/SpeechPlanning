using System;

namespace MarioMendonca.SpeechPlanning.Application.DTO.DTO
{
    public class CongregacaoDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public bool Local { get; set; }
        public bool Ativo { get; set; }
    }
}