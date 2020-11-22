using System.Linq;
using AutoMapper;
using MarioMendonca.SpeechPlanning.Application.DTO.DTO;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Map
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Cantico, CanticoDTO>();
            CreateMap<Congregacao, CongregacaoDTO>();
            CreateMap<Esboco, EsbocoDTO>()
                .ForMember(dto => dto.IdiomaNome, opt =>
                    opt.MapFrom(i => i.Idioma.Nome));
            CreateMap<Idioma, IdiomaDTO>()
                .ForMember(dto => dto.Esbocos, opt =>
                    opt.MapFrom(i => i.Esbocos.Select(x =>
                        new Esboco()
                        {
                            Id = x.Id,
                            Numero = x.Numero,
                            Titulo = x.Titulo,
                            Idioma = x.Idioma
                        })));
            CreateMap<Orador, OradorDTO>();
            CreateMap<Programacao, ProgramacaoDTO>();
        }
    }
}