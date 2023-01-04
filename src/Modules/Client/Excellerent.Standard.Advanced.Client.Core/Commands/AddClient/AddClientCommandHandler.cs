using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.DTO;
using Excellerent.Standard.Advanced.Shared.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Core.Commands.AddClient
{
    internal class AddClientCommandHandler : IRequestHandler<AddClientCommand, Response<Guid>>
    {
        private readonly IClientRepository _repository;

        public AddClientCommandHandler(IClientRepository repository)
        {
            _repository = repository;
        }
        public async Task<Response<Guid>> Handle(AddClientCommand request, CancellationToken cancellationToken)
        {
            var clientToAdd = await _repository.Add(request.Request.Client);

            return Response<Guid>.IsSuccessful(clientToAdd.Guid);
        }
    }
}
