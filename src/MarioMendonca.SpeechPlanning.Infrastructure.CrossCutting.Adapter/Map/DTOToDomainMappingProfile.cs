using AutoMapper;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Map
{
    public class DTOToDomainMappingProfile : Profile
    {
        public DTOToDomainMappingProfile()
        {
            CreateMap<CanticoDTO, Cantico>();
            CreateMap<CongregacaoDTO, Congregacao>();
            CreateMap<EsbocoDTO, Esboco>();
            CreateMap<IdiomaDTO, Idioma>();
            CreateMap<OradorDTO, Orador>();
            CreateMap<ProgramacaoDTO, Programacao>();
        }
    }
}