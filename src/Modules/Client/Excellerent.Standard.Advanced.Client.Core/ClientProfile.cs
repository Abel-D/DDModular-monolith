using AutoMapper;
using Excellerent.Standard.Advanced.Client.Core.Commands.AddClient;
using Excellerent.Standard.Advanced.Client.Core.Commands.UpdateClient;

namespace Excellerent.Standard.Advanced.Client.Core
{
    internal class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<Client, ClientEntity>();
            CreateMap<AddClientRequest, Client>();
            CreateMap<UpdateClientRequest, Client>();
            CreateMap<ClientEntity, Client>();
        }
    }
}
