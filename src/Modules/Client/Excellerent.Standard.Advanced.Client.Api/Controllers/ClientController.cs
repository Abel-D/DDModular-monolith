using Excellerent.Standard.Advanced.Client.Core.Commands.AddClient;
using Excellerent.Standard.Advanced.Client.Core.Queries.GetClients;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController:ControllerBase
    {
        private readonly IMediator _mediator;

        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }
       
        [HttpGet]
        public async Task<IActionResult> GetClients(GetClientsRequest request)
        {
            var clients = await _mediator.Send(new GetClientsQuery(request));
            return Ok(clients);
        }

        [HttpPost]
        public async Task<IActionResult> AddClient(AddClientRequest request)
        {
            var client = await _mediator.Send(new AddClientCommand(request));
            return Ok(client);
        }
    }
}
