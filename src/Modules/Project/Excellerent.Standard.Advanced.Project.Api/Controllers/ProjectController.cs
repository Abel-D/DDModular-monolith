using Excellerent.Standard.Advanced.Project.Core.Commands.Add_Project;
using Excellerent.Standard.Advanced.Project.Core.Commands.Delete_Project;
using Excellerent.Standard.Advanced.Project.Core.Commands.Update_Project;
using Excellerent.Standard.Advanced.Project.Core.Queries.GetProjectById;
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
            var addProject = await _mediator.Send(new AddProjectCommand(request));
            return Ok(addProject);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProject(UpdateProjectRequest request)
        {
            var updateProject = await _mediator.Send(new UpdateProjectCommand(request));
            return Ok(updateProject);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProject(DeleteProjectRequest request)
        {
            var deleteProject = await _mediator.Send(new DeleteProjectCommand(request));
            return Ok(deleteProject);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProjectById(GetProjectByIdRequest request)
        {
            var project = await _mediator.Send(new GetProjectByIdQuery(request));
            return Ok(project);
        }
    }
}
