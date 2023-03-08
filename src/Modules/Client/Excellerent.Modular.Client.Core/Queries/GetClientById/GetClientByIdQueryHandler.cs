using AutoMapper;
using Excellerent.Modular.Client.Core.Contracts;
using Excellerent.Modular.Shared.Application;
using MediatR;

namespace Excellerent.Modular.Client.Core.Queries.GetClientById
{
    internal class GetClientByIdQueryHandler : IRequestHandler<GetClientByIdQuery, Response<Client>>
    {
        private readonly IClientRepository _repository;
        private readonly IMapper _mapper;

        public GetClientByIdQueryHandler(IClientRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public async Task<Response<Client>> Handle(GetClientByIdQuery request, CancellationToken cancellationToken)
        {
            var client = await _repository.GetById(request.Request.ClientId);

            if (client == null)
            {
                return Response<Client>.IsError(new Exception(request.Request.ClientId.ToString() + " doesnot exist"));
            }

            return Response<Client>.IsSuccessful(_mapper.Map<Client>(client));
        }
    }
}
