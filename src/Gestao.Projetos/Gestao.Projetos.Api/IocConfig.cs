using AutoMapper;
using Gestao.Projetos.Application.Interfaces;
using Gestao.Projetos.Application.Mappings;
using Gestao.Projetos.Application.Services;
using Gestao.Projetos.Domain.Interfaces;
using Gestao.Projetos.Infra.MongoDb.Configuration;
using Gestao.Projetos.Infra.MongoDb.Repositories;

namespace Gestao.Projetos.Api
{
    public static class IocConfig
    {
        public static IServiceCollection ApplyIoC(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.AddTransient<IProjectRepository, ProjectRepository>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IProjectService, ProjectService>();

            IMapper mapper = MappingConfig.RegisterMap().CreateMapper();
            services.AddSingleton(mapper);
            services.AddAutoMapper(typeof(MappingConfig));

            services.Configure<MongoDBSettings>(configuration.GetSection("MongoDBSettings"));

            return services;
        }
    }
}
