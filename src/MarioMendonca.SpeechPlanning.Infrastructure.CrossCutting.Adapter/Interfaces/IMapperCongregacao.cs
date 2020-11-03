using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperCongregacao
    {
        #region Mappers

        Congregacao MapperToEntity(CongregacaoDTO congregacaoDto);

        IEnumerable<CongregacaoDTO> MapperListCongregacoes(IEnumerable<Congregacao> congregacoes);

        CongregacaoDTO MapperToDTO(Congregacao congregacao);

        #endregion
    }
}