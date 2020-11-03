using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperEsboco
    {
        #region Mappers

        Esboco MapperToEntity(EsbocoDTO esbocoDto);

        IEnumerable<EsbocoDTO> MapperListEsbocos(IEnumerable<Esboco> esbocos);

        EsbocoDTO MapperToDTO(Esboco esboco);

        #endregion
    }
}