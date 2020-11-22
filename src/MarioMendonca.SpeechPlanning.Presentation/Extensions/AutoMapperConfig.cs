using AutoMapper;
using MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Map;
using Microsoft.Extensions.DependencyInjection;

namespace MarioMendonca.SpeechPlanning.Presentation.Extensions
{
    public static class AutoMapperConfig
    {
        public static IServiceCollection RegisterMappings(this IServiceCollection services)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DomainToDtoMappingProfile>();
                cfg.AddProfile<DTOToDomainMappingProfile>();
            });

            IMapper mapper = configuration.CreateMapper();
            
            services.AddSingleton(mapper);

            return services;
        }
    }
}