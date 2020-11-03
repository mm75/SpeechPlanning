using System;
using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;

namespace MarioMendonca.SpeechPlanning.Application.Interfaces
{
    public interface IApplicationServiceOrador
    {
        void Add(OradorDTO obj);

        OradorDTO GetById(Guid id);

        IEnumerable<OradorDTO> GetAll();

        void Update(OradorDTO obj);

        void Remove(OradorDTO obj);

        void Dispose();
    }
}