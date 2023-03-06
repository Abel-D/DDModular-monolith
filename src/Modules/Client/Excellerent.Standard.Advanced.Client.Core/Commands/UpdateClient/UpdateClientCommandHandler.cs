using AutoMapper;
using Excellerent.Standard.Advanced.Client.Core.Contracts;
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
            Client client = new Client
            {
                Guid = request.Request.ClientId,
                Name = request.Request.Name,
                Description = request.Request.Description
            };
            var result = await _repository.Update(_mapper.Map<ClientEntity>(client));

            return Response<Guid>.IsSuccessful(result.Guid);
        }
    }
}
