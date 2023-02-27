using Excellerent.Standard.Advanced.Client.Core.Commands.AddClient;
using Excellerent.Standard.Advanced.Client.Core.Commands.DeleteClient;
using Excellerent.Standard.Advanced.Client.Core.Commands.UpdateClient;
using Excellerent.Standard.Advanced.Client.Core.Queries.GetClientById;
using Excellerent.Standard.Advanced.Client.Core.Queries.GetClients;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Excellerent.Standard.Advanced.Client.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetClients([FromQuery] GetClientsRequest request)
        {
            var clients = await _mediator.Send(new GetClientsQuery(request));
            return Ok(clients);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClientById([FromQuery] GetClientByIdRequest request)
        {
            var client = await _mediator.Send(new GetClientByIdQuery(request));
            return Ok(client);
        }
        [HttpPost]
        public async Task<IActionResult> AddClient([FromBody] AddClientRequest request)
        {
            var client = await _mediator.Send(new AddClientCommand(request));
            return Ok(client);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateClient([FromBody] UpdateClientRequest request)
        {
            var result = await _mediator.Send(new UpdateClientCommand(request));
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteClient(DeleteClientRequest request)
        {
            var result = await _mediator.Send(new DeleteClientCommand(request));
            return Ok(result);
        }
    }
}
