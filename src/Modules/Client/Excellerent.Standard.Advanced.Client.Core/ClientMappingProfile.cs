using AutoMapper;
using Excellerent.Standard.Advanced.Client.Core.Commands.AddClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Core
{
    internal class ClientMappingProfile:Profile
    {
        public ClientMappingProfile()
        {
            CreateMap<Client,ClientEntity>();
            CreateMap<AddClientRequest, Client>();
            CreateMap<AddClientRequest, ClientEntity>();
        }
    }
}
