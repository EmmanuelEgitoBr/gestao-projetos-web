using AutoMapper;
using Gestao.Projetos.Application.Dtos;
using Gestao.Projetos.Domain.Entities;

namespace Gestao.Projetos.Application.Mappings;

public class MappingConfig
{
    public static MapperConfiguration RegisterMap()
    {
        var mapperConfiguration = new MapperConfiguration(config =>
        {
            config.CreateMap<Project, ProjectDto>().ReverseMap();
            config.CreateMap<Person, PersonDto>().ReverseMap();
        }
        );
        return mapperConfiguration;
    }
}
