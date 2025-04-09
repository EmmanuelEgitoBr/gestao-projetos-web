using MongoDB.Bson.Serialization.Attributes;

namespace Gestao.Projetos.Domain.ValueObjects;

public class Category
{
    [BsonElement("categoryName")]
    public string CategoryName { get; set; } = string.Empty;
    [BsonElement("subcategories")]
    public List<Subcategory>? Subcategories { get; set; }
}
