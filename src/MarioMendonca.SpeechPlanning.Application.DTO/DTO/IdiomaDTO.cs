using System;
using System.Collections.Generic;

namespace MarioMendonca.SpeechPlanning.Application.DTO.DTO
{
    public class IdiomaDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public List<EsbocoDTO> Esbocos { get; set; }
    }
}