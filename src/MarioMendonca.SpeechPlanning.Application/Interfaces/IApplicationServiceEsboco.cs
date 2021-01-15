using System;
using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;

namespace MarioMendonca.SpeechPlanning.Application.Interfaces
{
    public interface IApplicationServiceEsboco
    {
        void Add(EsbocoDTO obj);

        EsbocoDTO GetById(Guid id);
        
        IEnumerable<EsbocoDTO> GetByTitulo(string titulo);

        IEnumerable<EsbocoDTO> GetAll();

        void Update(EsbocoDTO obj);

        void Remove(EsbocoDTO obj);

        void Dispose();
    }
}