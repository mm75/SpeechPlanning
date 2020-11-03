using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperIdioma : IMapperIdioma
    {
        #region properties

        List<IdiomaDTO> idiomaDtos = new List<IdiomaDTO>();

        #endregion

        #region methods

        public Idioma MapperToEntity(IdiomaDTO idiomaDto)
        {
            Idioma idioma = new Idioma
            {
                Id = idiomaDto.Id,
                Nome = idiomaDto.Nome
            };

            return idioma;
        }

        public IEnumerable<IdiomaDTO> MapperListIdiomas(IEnumerable<Idioma> idiomas)
        {
            foreach (var item in idiomas)
            {
                IdiomaDTO idiomaDto = new IdiomaDTO
                {
                    Id = item.Id,
                    Nome = item.Nome
                };

                idiomaDtos.Add(idiomaDto);
            }

            return idiomaDtos;
        }

        public IdiomaDTO MapperToDTO(Idioma idioma)
        {
            IdiomaDTO idiomaDto = new IdiomaDTO
            {
                Id = idioma.Id,
                Nome = idioma.Nome
            };

            return idiomaDto;
        }

        #endregion
    }
}