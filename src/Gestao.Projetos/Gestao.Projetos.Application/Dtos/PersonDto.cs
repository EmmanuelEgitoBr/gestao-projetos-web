namespace Gestao.Projetos.Application.Dtos;

public class PersonDto
{
    public string? Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public string? ProjectId { get; set; }
}
