
using AutoMapper;
using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Application;

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
            ClientEntity newClient = new ClientEntity
            {
                name = request.Request.Name,
                description = request.Request.Description
            };
            var result = await _repository.Add(newClient);

            return Response<Guid>.IsSuccessful(result.Guid);
        }
    }
}
