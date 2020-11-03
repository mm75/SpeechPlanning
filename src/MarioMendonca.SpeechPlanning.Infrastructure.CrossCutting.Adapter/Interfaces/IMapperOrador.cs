using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperOrador
    {
        #region Mappers

        Orador MapperToEntity(OradorDTO oradorDto);

        IEnumerable<OradorDTO> MapperListOradores(IEnumerable<Orador> oradores);

        OradorDTO MapperToDTO(Orador orador);

        #endregion
    }
}