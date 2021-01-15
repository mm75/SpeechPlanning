using System;

namespace MarioMendonca.SpeechPlanning.Domain.Models
{
    public class Programacao : BaseEntity
    {
        public Guid CongregacaoId { get; set; }
        public Guid OradorId { get; set; }
        public Guid EsbocoId { get; set; }
        public Guid CanticoId { get; set; }
        public DateTime Data { get; set; }
        public string Hora { get; set; }
        public virtual Congregacao Congregacao { get; set; }
        public virtual Orador Orador { get; set; }
        public virtual Esboco Esboco { get; set; }
        public virtual Cantico Cantico { get; set; }

    }
}