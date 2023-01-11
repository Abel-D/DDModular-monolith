using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.DTO;
using Excellerent.Standard.Advanced.Shared.Helpers;
using Excellerent.Standard.Advanced.Shared.Mapping;
using MediatR;

namespace Excellerent.Standard.Advanced.Client.Core.Queries.GetClients
{
    internal class GetClientsQueryHandler : IRequestHandler<GetClientsQuery, Response<PagedList<Client>>>
    {
        private readonly IClientRepository _repository;

        public GetClientsQueryHandler(IClientRepository repository)
        {
            _repository = repository;
        }
        public async Task<Response<PagedList<Client>>> Handle(GetClientsQuery request, CancellationToken cancellationToken)
        {

            var result = await _repository.GetAllAsync(request.request.PaginationParams);

            foreach(var res in result)
            {
                Mapper.Map<Client>(res);
            }
            return Response<PagedList<Client>>.IsSuccessful((PagedList<Client>)result);
        }
    }
}
