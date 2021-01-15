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
                    opt.MapFrom(e => e.Idioma.Nome));
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
            CreateMap<Orador, OradorDTO>()
                .ForMember(dto => dto.CongregacaoNome, opt =>
                    opt.MapFrom(o => o.Congregacao.Nome));
            CreateMap<Programacao, ProgramacaoDTO>()
                .ForMember(dto => dto.CongregacaoNome, opt =>
                    opt.MapFrom(p => p.Congregacao.Nome))
                .ForMember(dto => dto.OradorNome, opt =>
                    opt.MapFrom(p => p.Orador.Nome))
                .ForMember(dto => dto.EsbocoTitulo, opt =>
                    opt.MapFrom(p => p.Esboco.Titulo))
                .ForMember(dto => dto.CanticoTitulo, opt =>
                    opt.MapFrom(p => p.Cantico.Titulo));
        }
    }
}