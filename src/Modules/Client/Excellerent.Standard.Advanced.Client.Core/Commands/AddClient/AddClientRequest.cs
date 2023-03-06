using Excellerent.Standard.Advanced.Shared.Application;
using MediatR;

namespace Excellerent.Standard.Advanced.Client.Core.Commands.AddClient
{
    [Serializable]
    public class AddClientRequest : IRequest<Response<Guid>>
    {
        public AddClientRequest()
        {

        }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
