using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperIdioma
    {
        #region Mappers

        Idioma MapperToEntity(IdiomaDTO idiomaDto);

        IEnumerable<IdiomaDTO> MapperListIdiomas(IEnumerable<Idioma> idiomas);

        IdiomaDTO MapperToDTO(Idioma idioma);

        #endregion
    }
}