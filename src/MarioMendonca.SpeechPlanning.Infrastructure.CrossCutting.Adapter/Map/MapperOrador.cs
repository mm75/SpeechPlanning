using System.Collections.Generic;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Domain.Models;
using MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperOrador : IMapperOrador
    {
        #region properties

        List<OradorDTO> oradorDtos = new List<OradorDTO>();

        #endregion

        #region methods

        public Orador MapperToEntity(OradorDTO oradorDto)
        {
            Orador orador = new Orador
            {
                Id = oradorDto.Id,
                Nome = oradorDto.Nome,
                Telefone = oradorDto.Telefone
            };

            return orador;
        }

        public IEnumerable<OradorDTO> MapperListOradores(IEnumerable<Orador> oradores)
        {
            foreach (var item in oradores)
            {
                OradorDTO oradorDto = new OradorDTO
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Telefone = item.Telefone
                };

                oradorDtos.Add(oradorDto);
            }

            return oradorDtos;
        }

        public OradorDTO MapperToDTO(Orador orador)
        {
            OradorDTO oradorDto = new OradorDTO
            {
                Id = orador.Id,
                Nome = orador.Nome,
                Telefone = orador.Telefone
            };

            return oradorDto;
        }

        #endregion
    }
}