using Gestao.Projetos.Web.Models;

namespace Gestao.Projetos.Web.Services.Interfaces;

public interface IProjectService
{
    Task<ResponseDto> CreateProjectAsync(ProjectDto projectDto);
    Task<ResponseDto> DeleteProjectAsync(string id);
    Task<ResponseDto> GetAllProjectsAsync();
    Task<ResponseDto> GetProjectByIdAsync(string id);
    Task<ResponseDto> UpdateProjectAsync(string id, ProjectDto projectDto);
}
