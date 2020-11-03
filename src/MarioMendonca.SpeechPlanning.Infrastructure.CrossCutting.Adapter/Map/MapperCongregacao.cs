using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperCongregacao : IMapperCongregacao
    {
        #region properties

        List<CongregacaoDTO> congregacaoDtos = new List<CongregacaoDTO>();

        #endregion

        #region methods

        public Congregacao MapperToEntity(CongregacaoDTO congregacaoDto)
        {
            Congregacao congregacao = new Congregacao
            {
                Id = congregacaoDto.Id,
                Nome = congregacaoDto.Nome,
                Local = congregacaoDto.Local,
                Ativo = congregacaoDto.Ativo
            };

            return congregacao;
        }

        public IEnumerable<CongregacaoDTO> MapperListCongregacoes(IEnumerable<Congregacao> congregacoes)
        {
            foreach (var item in congregacoes)
            {
                CongregacaoDTO congregacaoDto = new CongregacaoDTO
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Local = item.Local,
                    Ativo = item.Ativo
                };

                congregacaoDtos.Add(congregacaoDto);
            }

            return congregacaoDtos;
        }

        public CongregacaoDTO MapperToDTO(Congregacao congregacao)
        {
            CongregacaoDTO congregacaoDto = new CongregacaoDTO
            {
                Id = congregacao.Id,
                Nome = congregacao.Nome,
                Local = congregacao.Local,
                Ativo = congregacao.Ativo
            };

            return congregacaoDto;
        }

        #endregion
    }
}