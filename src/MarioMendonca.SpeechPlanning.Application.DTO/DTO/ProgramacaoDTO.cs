using System;

namespace MarioMendonca.SpeechPlanning.Application.DTO.DTO
{
    public class ProgramacaoDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int CongregacaoId { get; set; }
        public int OradorId { get; set; }
        public int EsbocoId { get; set; }
        public int CanticoId { get; set; }
        public DateTime Data { get; set; }
        public string Hora { get; set; }
    }
}