using Gestao.Projetos.Application.Dtos;
using Gestao.Projetos.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gestao.Projetos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<List<ProjectDto>> GetAll()
        {
            var result = await _projectService.GetAllProjectsAsync();
            return result;
        }

        [HttpGet("{id}")]
        public async Task<ProjectDto> GetById(string id)
        {
            var result = await _projectService.GetProjectByIdAsync(id);
            return result!;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] ProjectDto projectDto)
        {
            await _projectService.CreateProjectAsync(projectDto);
            return Ok(projectDto);
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update(string id,
                                                [FromBody] ProjectDto projectDto)
        {
            await _projectService.UpdateProjectAsync(id, projectDto);
            return Ok(projectDto);
        }

        [HttpPost("delete/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _projectService.DeleteProjectAsync(id);
            return Ok(id);
        }
    }
}
