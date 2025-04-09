using Gestao.Projetos.Domain.ValueObjects;

namespace Gestao.Projetos.Application.Dtos;

public class ProjectDto
{
    public string? Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public Category? Category { get; set; }
}
