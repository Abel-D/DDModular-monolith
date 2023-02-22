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
        public async Task<IActionResult> GetProjects(GetProjectsRequest request)
        {
            var projects = await _mediator.Send(new GetProjectsQuery(request));

            return Ok(projects);
        }
    }
}
