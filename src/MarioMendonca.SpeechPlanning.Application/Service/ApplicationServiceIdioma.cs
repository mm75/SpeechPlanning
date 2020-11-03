using System;
using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Application.Interfaces;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services;
using MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace MarioMendonca.SpeechPlanning.Application.Service
{
    public class ApplicationServiceIdioma : IApplicationServiceIdioma
    {
        private readonly IServiceIdioma _serviceIdioma;
        private readonly IMapperIdioma _mapperIdioma;

        public ApplicationServiceIdioma(IServiceIdioma serviceIdioma, IMapperIdioma mapperIdioma)
        {
            _serviceIdioma = serviceIdioma;
            _mapperIdioma = mapperIdioma;
        }

        public void Add(IdiomaDTO obj)
        {
            var objIdioma = _mapperIdioma.MapperToEntity(obj);
            _serviceIdioma.Add(objIdioma);
        }

        public IdiomaDTO GetById(Guid id)
        {
            var objIdioma = _serviceIdioma.GetById(id);
            return _mapperIdioma.MapperToDTO(objIdioma);
        }

        public IEnumerable<IdiomaDTO> GetAll()
        {
            var objIdiomas = _serviceIdioma.GetAll();
            return _mapperIdioma.MapperListIdiomas(objIdiomas);
        }

        public void Update(IdiomaDTO obj)
        {
            var objIdioma = _mapperIdioma.MapperToEntity(obj);
            _serviceIdioma.Update(objIdioma);
        }

        public void Remove(IdiomaDTO obj)
        {
            var objIdioma = _mapperIdioma.MapperToEntity(obj);
            _serviceIdioma.Remove(objIdioma);
        }

        public void Dispose()
        {
            _serviceIdioma.Dispose();
        }
    }
}