using System;

namespace MarioMendonca.SpeechPlanning.Application.DTO.DTO
{
    public class ProgramacaoDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid CongregacaoId { get; set; }
        public string CongregacaoNome { get; set; }
        public Guid OradorId { get; set; }
        public string OradorNome { get; set; }
        public Guid EsbocoId { get; set; }
        public string EsbocoTitulo { get; set; }
        public Guid CanticoId { get; set; }
        public string CanticoTitulo { get; set; }
        public DateTime Data { get; set; }
        public string Hora { get; set; }
    }
}