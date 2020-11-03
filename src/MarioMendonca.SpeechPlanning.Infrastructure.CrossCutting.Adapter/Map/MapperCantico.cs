using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperCantico : IMapperCantico
    {
        #region properties

        List<CanticoDTO> canticoDtos = new List<CanticoDTO>();

        #endregion

        #region methods

        public Cantico MapperToEntity(CanticoDTO canticoDto)
        {
            Cantico cantico = new Cantico
            {
                Id = canticoDto.Id,
                Numero = canticoDto.Numero,
                Titulo = canticoDto.Titulo
            };

            return cantico;
        }

        public IEnumerable<CanticoDTO> MapperListCanticos(IEnumerable<Cantico> canticos)
        {
            foreach (var item in canticos)
            {
                CanticoDTO canticoDto = new CanticoDTO
                {
                    Id = item.Id,
                    Numero = item.Numero,
                    Titulo = item.Titulo
                };

                canticoDtos.Add(canticoDto);
            }

            return canticoDtos;
        }

        public CanticoDTO MapperToDTO(Cantico cantico)
        {
            CanticoDTO canticoDto = new CanticoDTO
            {
                Id = cantico.Id,
                Numero = cantico.Numero,
                Titulo = cantico.Titulo
            };

            return canticoDto;
        }

        #endregion
    }
}