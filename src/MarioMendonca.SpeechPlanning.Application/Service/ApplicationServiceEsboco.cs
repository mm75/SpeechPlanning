using System;
using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Application.Interfaces;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services;
using MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace MarioMendonca.SpeechPlanning.Application.Service
{
    public class ApplicationServiceEsboco : IApplicationServiceEsboco
    {
        private readonly IServiceEsboco _serviceEsboco;
        private readonly IMapperEsboco _mapperEsboco;

        public ApplicationServiceEsboco(IServiceEsboco serviceEsboco, IMapperEsboco mapperEsboco)
        {
            _serviceEsboco = serviceEsboco;
            _mapperEsboco = mapperEsboco;
        }

        public void Add(EsbocoDTO obj)
        {
            var objEsboco = _mapperEsboco.MapperToEntity(obj);
            _serviceEsboco.Add(objEsboco);
        }

        public EsbocoDTO GetById(Guid id)
        {
            var objEsboco = _serviceEsboco.GetById(id);
            return _mapperEsboco.MapperToDTO(objEsboco);
        }

        public IEnumerable<EsbocoDTO> GetAll()
        {
            var objEsbocos = _serviceEsboco.GetAll();
            return _mapperEsboco.MapperListEsbocos(objEsbocos);
        }

        public void Update(EsbocoDTO obj)
        {
            var objEsboco = _mapperEsboco.MapperToEntity(obj);
            _serviceEsboco.Update(objEsboco);
        }

        public void Remove(EsbocoDTO obj)
        {
            var objEsboco = _mapperEsboco.MapperToEntity(obj);
            _serviceEsboco.Remove(objEsboco);
        }

        public void Dispose()
        {
            _serviceEsboco.Dispose();
        }
    }
}