using Excellerent.Standard.Advanced.Shared.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Core.Commands.AddClient
{
    public record AddClientCommand:IRequest<Response<Guid>>
    {
        public AddClientRequest Request { get; set; }
        public AddClientCommand(AddClientRequest request)
        {
            this.Request = request; 
        }
    }
}
