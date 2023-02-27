using Excellerent.Standard.Advanced.Shared.Application;
using MediatR;

namespace Excellerent.Standard.Advanced.Client.Core.Queries.GetClientById
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
