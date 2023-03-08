using Excellerent.Modular.Shared.Application;
using MediatR;

namespace Excellerent.Modular.Client.Core.Queries.GetClientById
{
    public record GetClientByIdQuery : IRequest<Response<Client>>
    {
        public GetClientByIdQuery(GetClientByIdRequest request)
        {
            Request = request;
        }

        public GetClientByIdRequest Request { get; set; }
    }
}
