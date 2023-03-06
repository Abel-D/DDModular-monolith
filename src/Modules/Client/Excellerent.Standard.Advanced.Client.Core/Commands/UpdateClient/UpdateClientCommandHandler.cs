using AutoMapper;
using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Client.Core.ValueObjects;
using Excellerent.Standard.Advanced.Shared.Application;
using MediatR;

namespace Excellerent.Standard.Advanced.Client.Core.Commands.UpdateClient
{
    internal class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommand, Response<Guid>>
    {
        private readonly IClientRepository _repository;
        private readonly IMapper _mapper;

        public UpdateClientCommandHandler(IClientRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Response<Guid>> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            var client =_mapper.Map<ClientEntity>(request.Request);
            var result = await _repository.Update(client);

            return Response<Guid>.IsSuccessful(result.Guid);
        }
    }
}
