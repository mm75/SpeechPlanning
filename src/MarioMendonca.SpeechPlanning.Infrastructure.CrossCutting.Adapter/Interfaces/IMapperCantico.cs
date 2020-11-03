using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperCantico
    {
        #region Mappers

        Cantico MapperToEntity(CanticoDTO canticoDto);

        IEnumerable<CanticoDTO> MapperListCanticos(IEnumerable<Cantico> canticos);

        CanticoDTO MapperToDTO(Cantico cantico);

        #endregion
    }
}