using AutoMapper;
using Gestao.Projetos.Application.Dtos;
using Gestao.Projetos.Application.Interfaces;
using Gestao.Projetos.Domain.Entities;
using Gestao.Projetos.Domain.Interfaces;

namespace Gestao.Projetos.Application.Services;

internal class ProjectService : IProjectService
{
    private IMapper _mapper;
    private readonly IProjectRepository _projectRepository;

    public ProjectService(IMapper mapper, IProjectRepository projectRepository)
    {
        _mapper = mapper;
        _projectRepository = projectRepository;
    }

    public async Task CreateProjectAsync(ProjectDto project)
    {
        var projectEntity = _mapper.Map<Project>(project);
        await _projectRepository.CreateAsync(projectEntity);
    }

    public async Task DeleteProjectAsync(string id)
    {
        await _projectRepository.DeleteAsync(id);
    }

    public async Task<List<ProjectDto>> GetAllProjectsAsync()
    {
        var projectListEntity = await _projectRepository.GetAsync();
        return _mapper.Map<List<ProjectDto>>(projectListEntity);
    }

    public async Task<ProjectDto?> GetProjectByIdAsync(string id)
    {
        var projectEntity = await _projectRepository.GetByIdAsync(id);
        return _mapper.Map<ProjectDto>(projectEntity);
    }

    public async Task UpdateProjectAsync(string id, ProjectDto updatedProject)
    {
        var projectEntity = _mapper.Map<Project>(updatedProject);
        await _projectRepository.UpdateAsync(id, projectEntity);
    }
}
