using AutoMapper;
using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.DTO;
using Excellerent.Standard.Advanced.Shared.Entity;
using Excellerent.Standard.Advanced.Shared.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Core.Queries.GetClients
{
    internal class GetClientsQueryHandler : IRequestHandler<GetClientsQuery, Response<PagedList<Client>>>
    {
        private readonly IClientRepository _repository;
        private readonly IMapper _mapper;
       
        public GetClientsQueryHandler(IClientRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

            
        }
        public async Task<Response<PagedList<Client>>> Handle(GetClientsQuery request, CancellationToken cancellationToken)
        {
            
            var result = await _repository.GetAllAsync(request.request.PaginationParams);
            
            
            return Response<PagedList<Client>>.IsSuccessful((PagedList<Client>)result);
        }
    }
}
