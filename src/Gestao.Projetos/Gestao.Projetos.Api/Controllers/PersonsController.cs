using Gestao.Projetos.Application.Dtos;
using Gestao.Projetos.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Gestao.Projetos.Api.Controllers;

[Route("api/persons")]
[ApiController]
public class PersonsController : ControllerBase
{
    private readonly IPersonService _personService;

    public PersonsController(IPersonService personService)
    {
        _personService = personService;
    }

    [HttpGet]
    public async Task<List<PersonDto>> GetAll()
    {
        var result = await _personService.GetAllPersonsAsync();
        return result;
    }

    [HttpGet("{id}")]
    public async Task<PersonDto> GetById(string id)
    {
        var result = await _personService.GetPersonByIdAsync(id);
        return result!;
    }

    [HttpPost("associate/{personId}/{projectId}")]
    public async Task<IActionResult> Associate(string personId, string projectId)
    {
        await _personService.AssociateProjectToPersonAsync(personId, projectId);
        return Ok();
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] PersonDto personDto)
    {
        await _personService.CreatePersonAsync(personDto);
        return Ok(personDto);
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> Update(string id, 
                                            [FromBody] PersonDto personDto)
    {
        await _personService.UpdatePersonAsync(id, personDto);
        return Ok(personDto);
    }

    [HttpPost("delete/{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _personService.DeletePersonAsync(id);
        return Ok(id);
    }
}
