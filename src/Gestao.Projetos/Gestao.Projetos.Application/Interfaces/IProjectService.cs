using Gestao.Projetos.Application.Dtos;

namespace Gestao.Projetos.Application.Interfaces;

public interface IProjectService
{
    Task<List<ProjectDto>> GetAllProjectsAsync();
    Task<ProjectDto?> GetProjectByIdAsync(string id);
    Task CreateProjectAsync(ProjectDto project);
    Task UpdateProjectAsync(string id, ProjectDto updatedProject);
    Task DeleteProjectAsync(string id);
}
