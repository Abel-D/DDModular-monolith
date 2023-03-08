
using AutoMapper;
using Excellerent.Modular.Client.Core.Contracts;
using Excellerent.Modular.Shared.Application;
using MediatR;

namespace Excellerent.Modular.Client.Core.Commands.AddClient
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
            Client newClient = _mapper.Map<Client>(request.Request);
            var result = await _repository.Add(_mapper.Map<ClientEntity>(newClient));

            return Response<Guid>.IsSuccessful(result.Guid);
        }
    }
}
