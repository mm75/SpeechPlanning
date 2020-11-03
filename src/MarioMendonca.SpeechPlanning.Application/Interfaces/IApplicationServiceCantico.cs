using System;
using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;

namespace MarioMendonca.SpeechPlanning.Application.Interfaces
{
    public interface IApplicationServiceCantico
    {
        void Add(CanticoDTO obj);

        CanticoDTO GetById(Guid id);

        IEnumerable<CanticoDTO> GetAll();

        void Update(CanticoDTO obj);

        void Remove(CanticoDTO obj);

        void Dispose();
    }
}