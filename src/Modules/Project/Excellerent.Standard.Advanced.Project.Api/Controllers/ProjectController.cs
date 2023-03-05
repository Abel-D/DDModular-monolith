using Excellerent.Standard.Advanced.Project.Core.Commands.Add_Project;
using Excellerent.Standard.Advanced.Project.Core.Queries.GetProjects;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Excellerent.Standard.Advanced.Project.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjectController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetProjects([FromQuery]GetProjectsRequest request)
        {
            var projects = await _mediator.Send(new GetProjectsQuery(request));

            return Ok(projects);
        }
        [HttpPost]
        public async Task<IActionResult> AddProject([FromBody] AddProjectRequest request)
        {
            var addedProject = await _mediator.Send(new AddProjectCommand(request));
            return Ok(addedProject);
        }
        [HttpPost("Project")]
        public async Task<IActionResult> AddProject2([FromQuery] AddProjectRequest request)
        {
            var addedProject = await _mediator.Send(new AddProjectCommand(request));
            return Ok(addedProject);
        }

    }
}
