using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperEsboco : IMapperEsboco
    {
        #region properties

        List<EsbocoDTO> esbocoDtos = new List<EsbocoDTO>();

        #endregion

        #region methods

        public Esboco MapperToEntity(EsbocoDTO esbocoDto)
        {
            Esboco esboco = new Esboco
            {
                Id = esbocoDto.Id,
                Numero = esbocoDto.Numero,
                Titulo = esbocoDto.Titulo,
                IdiomaId = esbocoDto.IdiomaId
            };

            return esboco;
        }

        public IEnumerable<EsbocoDTO> MapperListEsbocos(IEnumerable<Esboco> esbocos)
        {
            foreach (var item in esbocos)
            {
                EsbocoDTO esbocoDto = new EsbocoDTO
                {
                    Id = item.Id,
                    Numero = item.Numero,
                    Titulo = item.Titulo,
                    IdiomaId = item.IdiomaId
                };

                esbocoDtos.Add(esbocoDto);
            }

            return esbocoDtos;
        }

        public EsbocoDTO MapperToDTO(Esboco esboco)
        {
            EsbocoDTO esbocoDto = new EsbocoDTO
            {
                Id = esboco.Id,
                Numero = esboco.Numero,
                Titulo = esboco.Titulo,
                IdiomaId = esboco.IdiomaId/*,
                Idioma = esboco.Idioma*/
            };

            return esbocoDto;
        }

        #endregion
    }
}