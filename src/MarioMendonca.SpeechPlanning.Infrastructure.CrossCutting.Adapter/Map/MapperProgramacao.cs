using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperProgramacao : IMapperProgramacao
    {
        #region properties

        List<ProgramacaoDTO> programacaoDtos = new List<ProgramacaoDTO>();

        #endregion

        #region methods

        public Programacao MapperToEntity(ProgramacaoDTO programacaoDto)
        {
            Programacao programacao = new Programacao
            {
                Id = programacaoDto.Id,
                CongregacaoId = programacaoDto.CongregacaoId,
                EsbocoId = programacaoDto.EsbocoId,
                CanticoId = programacaoDto.CanticoId,
                Data = programacaoDto.Data,
                Hora = programacaoDto.Hora
            };

            return programacao;
        }

        public IEnumerable<ProgramacaoDTO> MapperListProgramacoes(IEnumerable<Programacao> programacoes)
        {
            foreach (var item in programacoes)
            {
                ProgramacaoDTO programacaoDto = new ProgramacaoDTO
                {
                    Id = item.Id,
                    CongregacaoId = item.CongregacaoId,
                    EsbocoId = item.EsbocoId,
                    CanticoId = item.CanticoId,
                    Data = item.Data,
                    Hora = item.Hora
                };

                programacaoDtos.Add(programacaoDto);
            }

            return programacaoDtos;
        }

        public ProgramacaoDTO MapperToDTO(Programacao programacao)
        {
            ProgramacaoDTO programacaoDto = new ProgramacaoDTO
            {
                Id = programacao.Id,
                CongregacaoId = programacao.CongregacaoId,
                EsbocoId = programacao.EsbocoId,
                CanticoId = programacao.CanticoId,
                Data = programacao.Data,
                Hora = programacao.Hora
            };

            return programacaoDto;
        }

        #endregion
    }
}