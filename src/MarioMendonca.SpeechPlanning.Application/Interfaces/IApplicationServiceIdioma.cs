using System;
using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;

namespace MarioMendonca.SpeechPlanning.Application.Interfaces
{
    public interface IApplicationServiceIdioma
    {
        void Add(IdiomaDTO obj);

        IdiomaDTO GetById(Guid id);

        IEnumerable<IdiomaDTO> GetAll();

        void Update(IdiomaDTO obj);

        void Remove(IdiomaDTO obj);

        void Dispose();
    }
}