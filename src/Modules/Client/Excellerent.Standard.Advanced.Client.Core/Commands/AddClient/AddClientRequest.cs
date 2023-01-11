using Excellerent.Standard.Advanced.Shared.DTO;
using Excellerent.Standard.Advanced.Shared.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static ClientEntity FromRequest(AddClientRequest request)
        {
            ClientEntity entity = new ClientEntity()
            {
                Name = request.Name,
                Description = request.Description
            };
            return entity;
        }
    }
}
