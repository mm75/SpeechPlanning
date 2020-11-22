using System.Collections.Generic;
using System.Linq;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Repositorys;
using MarioMendonca.SpeechPlanning.Domain.Core.Interfaces.Services;
using MarioMendonca.SpeechPlanning.Domain.Models;

namespace MarioMendonca.SpeechPlanning.Domain.Services.Services
{
    public class ServiceIdioma : ServiceBase<Idioma>, IServiceIdioma
    {
        public readonly IRepositoryIdioma _RepositoryIdioma;
        
        public ServiceIdioma(IRepositoryIdioma repositoryIdioma) : base(repositoryIdioma)
        {
            _RepositoryIdioma = repositoryIdioma;
        }
        
        public IEnumerable<Idioma> GetByNome(string nome)
        {
            return _RepositoryIdioma.GetByNome(nome).Cast<Idioma>().AsEnumerable();
        }

    }
}