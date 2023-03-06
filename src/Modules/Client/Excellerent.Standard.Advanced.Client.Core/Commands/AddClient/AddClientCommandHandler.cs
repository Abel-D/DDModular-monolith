﻿
using AutoMapper;
using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Application;
using MediatR;

namespace Excellerent.Standard.Advanced.Client.Core.Commands.AddClient
{
    public class AddClientCommandHandler : IRequestHandler<AddClientCommand, Response<Guid>>
    {
        private readonly IClientRepository _repository;
        private readonly IMapper _mapper;

        public AddClientCommandHandler(IClientRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Response<Guid>> Handle(AddClientCommand request, CancellationToken cancellationToken)
        {
            ClientEntity newClient = _mapper.Map<ClientEntity>(request.Request);
            var result = await _repository.Add(newClient);

            return Response<Guid>.IsSuccessful(result.Guid);
        }
    }
}
