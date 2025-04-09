using Gestao.Projetos.Domain.ValueObjects;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Gestao.Projetos.Domain.Entities;

public class Project
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    [BsonElement("title")]
    public string Title { get; set; } = string.Empty;
    [BsonElement("description")]
    public string Description { get; set; } = string.Empty;
    [BsonElement("createdDate")]
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    [BsonElement("category")]
    public Category? Category { get; set; }
}
