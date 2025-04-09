namespace Gestao.Projetos.Domain.Entities;

public class Person
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public Guid? ProjectId { get; set; }
}
