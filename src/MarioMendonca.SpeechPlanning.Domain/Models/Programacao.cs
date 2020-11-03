using System;

namespace MarioMendonca.SpeechPlanning.Domain.Models
{
    public class Programacao : BaseEntity
    {
        public int CongregacaoId { get; set; }
        public int OradorId { get; set; }
        public int EsbocoId { get; set; }
        public int CanticoId { get; set; }
        public DateTime Data { get; set; }
        public string Hora { get; set; }
    }
}