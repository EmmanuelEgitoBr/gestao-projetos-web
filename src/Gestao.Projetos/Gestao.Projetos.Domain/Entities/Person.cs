using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Gestao.Projetos.Domain.Entities;

public class Person
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    [BsonElement("name")]
    public string Name { get; set; } = string.Empty;
    [BsonElement("position")]
    public string Position { get; set; } = string.Empty;
    [BsonElement("projectId")]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? ProjectId { get; set; }
}
