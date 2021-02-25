using Autofac;
using MarioMendonca.SpeechPlanning.Application.Interfaces;
using MarioMendonca.SpeechPlanning.Application.Service;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services;
using MarioMendonca.SpeechPlanning.Domain.Services.Services;
using MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Interfaces;
using MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.Adapter.Map;
using MarioMendonca.SpeechPlanning.Infrastructure.Repository.Repositories;

namespace MarioMendonca.SpeechPlanning.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceCantico>().As<IApplicationServiceCantico>();
            builder.RegisterType<ApplicationServiceCongregacao>().As<IApplicationServiceCongregacao>();
            builder.RegisterType<ApplicationServiceEsboco>().As<IApplicationServiceEsboco>();
            builder.RegisterType<ApplicationServiceIdioma>().As<IApplicationServiceIdioma>();
            builder.RegisterType<ApplicationServiceOrador>().As<IApplicationServiceOrador>();
            builder.RegisterType<ApplicationServiceProgramacao>().As<IApplicationServiceProgramacao>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceCantico>().As<IServiceCantico>();
            builder.RegisterType<ServiceCongregacao>().As<IServiceCongregacao>();
            builder.RegisterType<ServiceEsboco>().As<IServiceEsboco>();
            builder.RegisterType<ServiceIdioma>().As<IServiceIdioma>();
            builder.RegisterType<ServiceOrador>().As<IServiceOrador>();
            builder.RegisterType<ServiceProgramacao>().As<IServiceProgramacao>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryCantico>().As<IRepositoryCantico>();
            builder.RegisterType<RepositoryCongregacao>().As<IRepositoryCongregacao>();
            builder.RegisterType<RepositoryEsboco>().As<IRepositoryEsboco>();
            builder.RegisterType<RepositoryIdioma>().As<IRepositoryIdioma>();
            builder.RegisterType<RepositoryOrador>().As<IRepositoryOrador>();
            builder.RegisterType<RepositoryProgramacao>().As<IRepositoryProgramacao>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperCantico>().As<IMapperCantico>();
            builder.RegisterType<MapperCongregacao>().As<IMapperCongregacao>();
            builder.RegisterType<MapperEsboco>().As<IMapperEsboco>();
            builder.RegisterType<MapperIdioma>().As<IMapperIdioma>();
            builder.RegisterType<MapperOrador>().As<IMapperOrador>();
            builder.RegisterType<MapperProgramacao>().As<IMapperProgramacao>();
            #endregion

            #endregion

        }
    }
}