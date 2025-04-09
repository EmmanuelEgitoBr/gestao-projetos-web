namespace Gestao.Projetos.Domain.ValueObjects;

public class Category
{
    public string CategoryName { get; set; } = string.Empty;
    public List<Subcategory>? Subcategories { get; set; }
}
