using System;
using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Application.Interfaces;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services;
using MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace MarioMendonca.SpeechPlanning.Application.Service
{
    public class ApplicationServiceProgramacao : IApplicationServiceProgramacao
    {
        private readonly IServiceProgramacao _serviceProgramacao;
        private readonly IMapperProgramacao _mapperProgramacao;

        public ApplicationServiceProgramacao(IServiceProgramacao serviceProgramacao, IMapperProgramacao mapperProgramacao)
        {
            _serviceProgramacao = serviceProgramacao;
            _mapperProgramacao = mapperProgramacao;
        }

        public void Add(ProgramacaoDTO obj)
        {
            var objProgramacao = _mapperProgramacao.MapperToEntity(obj);
            _serviceProgramacao.Add(objProgramacao);
        }

        public ProgramacaoDTO GetById(Guid id)
        {
            var objProgramacao = _serviceProgramacao.GetById(id);
            return _mapperProgramacao.MapperToDTO(objProgramacao);
        }

        public IEnumerable<ProgramacaoDTO> GetAll()
        {
            var objProgramacoes = _serviceProgramacao.GetAll();
            return _mapperProgramacao.MapperListProgramacoes(objProgramacoes);
        }

        public void Update(ProgramacaoDTO obj)
        {
            var objProgramacao = _mapperProgramacao.MapperToEntity(obj);
            _serviceProgramacao.Update(objProgramacao);
        }

        public void Remove(ProgramacaoDTO obj)
        {
            var objProgramacao = _mapperProgramacao.MapperToEntity(obj);
            _serviceProgramacao.Remove(objProgramacao);
        }

        public void Dispose()
        {
            _serviceProgramacao.Dispose();
        }
    }
}