using Gestao.Projetos.Domain.Entities;

namespace Gestao.Projetos.Domain.Interfaces;

public interface IProjectRepository
{
    Task<List<Project>> GetAsync();
    Task<Project?> GetByIdAsync(string id);
    Task CreateAsync(Project project);
    Task UpdateAsync(string id, Project updatedProject);
    Task DeleteAsync(string id);
}
