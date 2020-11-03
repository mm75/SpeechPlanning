using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperProgramacao
    {
        #region Mappers

        Programacao MapperToEntity(ProgramacaoDTO programacaoDto);

        IEnumerable<ProgramacaoDTO> MapperListProgramacoes(IEnumerable<Programacao> programacoes);

        ProgramacaoDTO MapperToDTO(Programacao programacao);

        #endregion
    }
}