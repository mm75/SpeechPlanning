using System;
using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;

namespace MarioMendonca.SpeechPlanning.Application.Interfaces
{
    public interface IApplicationServiceProgramacao
    {
        void Add(ProgramacaoDTO obj);

        ProgramacaoDTO GetById(Guid id);

        IEnumerable<ProgramacaoDTO> GetAll();

        void Update(ProgramacaoDTO obj);

        void Remove(ProgramacaoDTO obj);

        void Dispose();
    }
}