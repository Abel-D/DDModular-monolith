
using AutoMapper;
using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Api.DTO;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Contracts.Command;
using MediatR;

namespace Excellerent.Standard.Advanced.Client.Core.Commands.AddClient
{
    public class AddClientCommandHandler : IRequestHandler<AddClientCommand, Response<Guid>>
    {
        private readonly IClientRepository _repository;
        private readonly IMapper _mapper;

        public AddClientCommandHandler(IClientRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Response<Guid>> Handle(AddClientCommand request, CancellationToken cancellationToken)
        {
            var result = await _repository.Add(_mapper.Map<ClientEntity>(request.Request));

            return Response<Guid>.IsSuccessful(result.Guid);
        }
    }
}
