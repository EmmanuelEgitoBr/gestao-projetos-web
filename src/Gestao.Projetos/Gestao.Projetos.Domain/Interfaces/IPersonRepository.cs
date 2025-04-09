using Gestao.Projetos.Domain.Entities;

namespace Gestao.Projetos.Domain.Interfaces;

public interface IPersonRepository
{
    Task<List<Person>> GetAsync();
    Task<Person?> GetByIdAsync(string id);
    Task CreateAsync(Person person);
    Task UpdateAsync(string id, Person updatedPerson);
    Task DeleteAsync(string id);
}
