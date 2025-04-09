using MongoDB.Bson.Serialization.Attributes;

namespace Gestao.Projetos.Domain.ValueObjects;

public class Subcategory
{
    [BsonElement("subcategoryName")]
    public string SubcategoryName { get; set; } = string.Empty;
}
