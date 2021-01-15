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
                OradorId = programacaoDto.OradorId,
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
                    CongregacaoNome = item.Congregacao.Nome,
                    OradorId = item.OradorId,
                    OradorNome = item.Orador.Nome,
                    EsbocoId = item.EsbocoId,
                    EsbocoTitulo = item.Esboco.Titulo,
                    CanticoId = item.CanticoId,
                    CanticoTitulo = item.Cantico.Titulo,
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
                CongregacaoNome = programacao.Congregacao.Nome,
                OradorId = programacao.OradorId,
                OradorNome = programacao.Orador.Nome,
                EsbocoId = programacao.EsbocoId,
                EsbocoTitulo = programacao.Esboco.Titulo,
                CanticoId = programacao.CanticoId,
                CanticoTitulo = programacao.Cantico.Titulo,
                Data = programacao.Data,
                Hora = programacao.Hora
            };

            return programacaoDto;
        }

        #endregion
    }
}