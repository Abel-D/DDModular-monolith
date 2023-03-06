using AutoMapper;
using Excellerent.Standard.Advanced.Client.Core.Commands.AddClient;
using Excellerent.Standard.Advanced.Client.Core.Commands.UpdateClient;

namespace Excellerent.Standard.Advanced.Client.Core
{
    internal class ClientMappingProfile : Profile
    {
        public ClientMappingProfile()
        {
            CreateMap<Client, ClientEntity>();
            CreateMap<AddClientRequest, Client>();
            CreateMap<AddClientRequest, ClientEntity>();
            CreateMap<UpdateClientRequest, ClientEntity>();
            CreateMap<ClientEntity, Client>();
        }
    }
}
