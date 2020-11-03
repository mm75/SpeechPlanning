using System;

namespace MarioMendonca.SpeechPlanning.Application.DTO.DTO
{
    public class OradorDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int CongregacaoId { get; set; }
        public bool Ativo { get; set; }
    }
}