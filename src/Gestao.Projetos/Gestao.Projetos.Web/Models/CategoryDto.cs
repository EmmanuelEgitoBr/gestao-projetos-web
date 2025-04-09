namespace Gestao.Projetos.Web.Models;

public class CategoryDto
{
    public string CategoryName { get; set; } = string.Empty;
    public List<SubcategoryDto>? Subcategories { get; set; }
}
