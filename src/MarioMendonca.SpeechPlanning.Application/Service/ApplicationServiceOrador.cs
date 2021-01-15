using System;
using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Application.Interfaces;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services;
using MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace MarioMendonca.SpeechPlanning.Application.Service
{
    public class ApplicationServiceOrador : IApplicationServiceOrador
    {
        private readonly IServiceOrador _serviceOrador;
        private readonly IMapperOrador _mapperOrador;

        public ApplicationServiceOrador(IServiceOrador serviceOrador, IMapperOrador mapperOrador)
        {
            _serviceOrador = serviceOrador;
            _mapperOrador = mapperOrador;
        }

        public void Add(OradorDTO obj)
        {
            var objOrador = _mapperOrador.MapperToEntity(obj);
            _serviceOrador.Add(objOrador);
        }

        public OradorDTO GetById(Guid id)
        {
            var objOrador = _serviceOrador.GetById(id);
            return _mapperOrador.MapperToDTO(objOrador);
        }

        public IEnumerable<OradorDTO> GetByNome(string nome)
        {
            var objOradores = _serviceOrador.GetByNome(nome);
            return _mapperOrador.MapperListOradores(objOradores);
        }

        public IEnumerable<OradorDTO> GetAll()
        {
            var objOradores = _serviceOrador.GetAll();
            return _mapperOrador.MapperListOradores(objOradores);
        }

        public void Update(OradorDTO obj)
        {
            var objOrador = _mapperOrador.MapperToEntity(obj);
            _serviceOrador.Update(objOrador);
        }

        public void Remove(OradorDTO obj)
        {
            var objOrador = _mapperOrador.MapperToEntity(obj);
            _serviceOrador.Remove(objOrador);
        }

        public void Dispose()
        {
            _serviceOrador.Dispose();
        }
    }
}