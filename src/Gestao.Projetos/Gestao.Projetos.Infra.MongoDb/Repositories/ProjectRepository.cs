using Gestao.Projetos.Domain.Entities;
using Gestao.Projetos.Domain.Interfaces;
using Gestao.Projetos.Infra.MongoDb.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Gestao.Projetos.Infra.MongoDb.Repositories;

public class ProjectRepository : IProjectRepository
{
    private readonly IMongoCollection<Project> _projectCollection;

    public ProjectRepository(IOptions<MongoDBSettings> settings)
    {
        var project = new MongoClient(settings.Value.ConnectionString);
        var database = project.GetDatabase(settings.Value.DatabaseName);
        _projectCollection = database.GetCollection<Project>("Projetos");
    }

    public async Task<List<Project>> GetAsync() =>
        await _projectCollection.Find(_ => true).ToListAsync();

    public async Task<Project?> GetByIdAsync(string id) =>
        await _projectCollection.Find(c => c.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Project project) =>
        await _projectCollection.InsertOneAsync(project);

    public async Task UpdateAsync(string id, Project updatedProject) =>
        await _projectCollection.ReplaceOneAsync(c => c.Id == id, updatedProject);

    public async Task DeleteAsync(string id) =>
        await _projectCollection.DeleteOneAsync(c => c.Id == id);
}
