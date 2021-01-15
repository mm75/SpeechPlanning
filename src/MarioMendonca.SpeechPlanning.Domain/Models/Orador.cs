using System;

namespace MarioMendonca.SpeechPlanning.Domain.Models
{
    public class Orador : BaseEntity
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Guid CongregacaoId { get; set; }
        public bool Ativo { get; set; }
        public virtual Congregacao Congregacao { get; set; }
    }
}