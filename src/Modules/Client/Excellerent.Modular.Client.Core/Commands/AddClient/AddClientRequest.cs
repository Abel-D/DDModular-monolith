using Excellerent.Modular.Shared.Application;
using MediatR;

namespace Excellerent.Modular.Client.Core.Commands.AddClient
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
