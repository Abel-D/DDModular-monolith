using Excellerent.Standard.Advanced.Shared.Application;
using MediatR;

namespace Excellerent.Standard.Advanced.Client.Core.Commands.AddClient
{
    [Serializable]
    public class AddClientRequest : IRequest<Response<Guid>>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public AddClientRequest(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
