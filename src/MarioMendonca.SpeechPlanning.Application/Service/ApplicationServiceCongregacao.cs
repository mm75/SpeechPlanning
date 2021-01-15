using System;
using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Application.Interfaces;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services;
using MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace MarioMendonca.SpeechPlanning.Application.Service
{
    public class ApplicationServiceCongregacao : IApplicationServiceCongregacao
    {
        private readonly IServiceCongregacao _serviceCongregacao;
        private readonly IMapperCongregacao _mapperCongregacao;

        public ApplicationServiceCongregacao(IServiceCongregacao serviceCongregacao, IMapperCongregacao mapperCongregacao)
        {
            _serviceCongregacao = serviceCongregacao;
            _mapperCongregacao = mapperCongregacao;
        }

        public void Add(CongregacaoDTO obj)
        {
            var objCongregacao = _mapperCongregacao.MapperToEntity(obj);
            _serviceCongregacao.Add(objCongregacao);
        }

        public CongregacaoDTO GetById(Guid id)
        {
            var objCongregacao = _serviceCongregacao.GetById(id);
            return _mapperCongregacao.MapperToDTO(objCongregacao);
        }

        public IEnumerable<CongregacaoDTO> GetByNome(string nome)
        {
            var objCongregacoes = _serviceCongregacao.GetByNome(nome);
            return _mapperCongregacao.MapperListCongregacoes(objCongregacoes);
        }

        public IEnumerable<CongregacaoDTO> GetAll()
        {
            var objCongregacoes = _serviceCongregacao.GetAll();
            return _mapperCongregacao.MapperListCongregacoes(objCongregacoes);
        }

        public void Update(CongregacaoDTO obj)
        {
            var objCongregacao = _mapperCongregacao.MapperToEntity(obj);
            _serviceCongregacao.Update(objCongregacao);
        }

        public void Remove(CongregacaoDTO obj)
        {
            var objCongregacao = _mapperCongregacao.MapperToEntity(obj);
            _serviceCongregacao.Remove(objCongregacao);
        }

        public void Dispose()
        {
            _serviceCongregacao.Dispose();
        }
    }
}