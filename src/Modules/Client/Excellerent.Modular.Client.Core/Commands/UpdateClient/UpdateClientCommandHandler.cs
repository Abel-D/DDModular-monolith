using AutoMapper;
using Excellerent.Modular.Client.Core.Contracts;
using Excellerent.Modular.Shared.Application;
using MediatR;

namespace Excellerent.Modular.Client.Core.Commands.UpdateClient
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
            var clientToUpdate = await _repository.GetById(client.Guid);
            if(clientToUpdate == null)
            {
                return Response<Guid>.IsError(new Exception(client.Guid + "does not exist"));
            }
            var result = await _repository.Update(_mapper.Map<ClientEntity>(client));

            return Response<Guid>.IsSuccessful(result.Guid);
        }
    }
}
