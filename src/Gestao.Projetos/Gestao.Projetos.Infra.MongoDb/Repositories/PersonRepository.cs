using Gestao.Projetos.Domain.Entities;
using Gestao.Projetos.Domain.Interfaces;
using Gestao.Projetos.Infra.MongoDb.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Gestao.Projetos.Infra.MongoDb.Repositories;

public class PersonRepository : IPersonRepository
{
    private readonly IMongoCollection<Person> _personCollection;

    public PersonRepository(IOptions<MongoDBSettings> settings)
    {
        var person = new MongoClient(settings.Value.ConnectionString);
        var database = person.GetDatabase(settings.Value.DatabaseName);
        _personCollection = database.GetCollection<Person>("Pessoas");
    }

    public async Task<List<Person>> GetAsync() =>
        await _personCollection.Find(_ => true).ToListAsync();

    public async Task<Person?> GetByIdAsync(string id) =>
        await _personCollection.Find(c => c.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Person person) =>
        await _personCollection.InsertOneAsync(person);

    public async Task UpdateAsync(string id, Person updatedPerson) =>
        await _personCollection.ReplaceOneAsync(c => c.Id == id, updatedPerson);

    public async Task DeleteAsync(string id) =>
        await _personCollection.DeleteOneAsync(c => c.Id == id);

    public async Task AssociateProjectToPersonAsync(string personId, string projectId)
    {
        var person = await _personCollection.Find(c => c.Id == personId).FirstOrDefaultAsync();
        person.ProjectId = projectId;
        await _personCollection.ReplaceOneAsync(c => c.Id == personId, person);
    }
}
