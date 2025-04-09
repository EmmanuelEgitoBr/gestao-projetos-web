using Gestao.Projetos.Domain.ValueObjects;

namespace Gestao.Projetos.Domain.Entities;

public class Project
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public Category? Category { get; set; }
}
