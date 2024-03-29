﻿using AutoMapper;
using Excellerent.Modular.Client.Core.Contracts;
using Excellerent.Modular.Shared.Application;
using Excellerent.Modular.Shared.Application.Helpers;
using MediatR;

namespace Excellerent.Modular.Client.Core.Queries.GetClients
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
            List<Client> clients = new List<Client>();
            foreach (var res in result)
            {
                Client client = _mapper.Map<Client>(res);
                clients.Add(client);
            }

            return Response<PagedList<Client>>.IsSuccessful(PagedList<Client>.ToPagedList(clients, request.request.PaginationParams.PageNumber, request.request.PaginationParams.PageSize));
        }
    }
}
