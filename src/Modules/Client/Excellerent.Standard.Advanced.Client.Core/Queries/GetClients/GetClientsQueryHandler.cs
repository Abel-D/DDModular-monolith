using AutoMapper;
using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Api.DTO;
using Excellerent.Standard.Advanced.Shared.Application.Helpers;
using MediatR;

namespace Excellerent.Standard.Advanced.Client.Core.Queries.GetClients
{
    public class GetClientsQueryHandler : IRequestHandler<GetClientsQuery, Response<PagedList<Client>>>
    {
        private readonly IClientRepository _repository;
        private readonly IMapper _mapper;

        public GetClientsQueryHandler(IClientRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Response<PagedList<Client>>> Handle(GetClientsQuery request, CancellationToken cancellationToken)
        {

            var result = await _repository.GetAllAsync(request.request.PaginationParams);

            foreach (var res in result)
            {
                _mapper.Map<Client>(res);
            }
            return Response<PagedList<Client>>.IsSuccessful((PagedList<Client>)result);
        }
    }
}
