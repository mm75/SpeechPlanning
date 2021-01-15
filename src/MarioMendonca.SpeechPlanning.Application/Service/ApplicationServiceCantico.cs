using System;
using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Application.Interfaces;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services;
using MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace MarioMendonca.SpeechPlanning.Application.Service
{
    public class ApplicationServiceCantico : IApplicationServiceCantico
    {
        private readonly IServiceCantico _serviceCantico;
        private readonly IMapperCantico _mapperCantico;

        public ApplicationServiceCantico(IServiceCantico serviceCantico, IMapperCantico mapperCantico)
        {
            _serviceCantico = serviceCantico;
            _mapperCantico = mapperCantico;
        }

        public void Add(CanticoDTO obj)
        {
            var objCantico = _mapperCantico.MapperToEntity(obj);
            _serviceCantico.Add(objCantico);
        }

        public CanticoDTO GetById(Guid id)
        {
            var objCantico = _serviceCantico.GetById(id);
            return _mapperCantico.MapperToDTO(objCantico);
        }

        public IEnumerable<CanticoDTO> GetByTitulo(string titulo)
        {
            var objCanticos = _serviceCantico.GetByTitulo(titulo);
            return _mapperCantico.MapperListCanticos(objCanticos);
        }

        public IEnumerable<CanticoDTO> GetAll()
        {
            var objCanticos = _serviceCantico.GetAll();
            return _mapperCantico.MapperListCanticos(objCanticos);
        }

        public void Update(CanticoDTO obj)
        {
            var objCantico = _mapperCantico.MapperToEntity(obj);
            _serviceCantico.Update(objCantico);
        }

        public void Remove(CanticoDTO obj)
        {
            var objCantico = _mapperCantico.MapperToEntity(obj);
            _serviceCantico.Remove(objCantico);
        }

        public void Dispose()
        {
            _serviceCantico.Dispose();
        }
    }
}