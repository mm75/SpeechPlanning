using System;
using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;

namespace MarioMendonca.SpeechPlanning.Application.Interfaces
{
    public interface IApplicationServiceCongregacao
    {
        void Add(CongregacaoDTO obj);

        CongregacaoDTO GetById(Guid id);

        IEnumerable<CongregacaoDTO> GetAll();

        void Update(CongregacaoDTO obj);

        void Remove(CongregacaoDTO obj);

        void Dispose();
    }
}