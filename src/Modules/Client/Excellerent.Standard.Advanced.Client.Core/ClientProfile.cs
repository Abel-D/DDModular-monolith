using AutoMapper;
using Excellerent.Standard.Advanced.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Core
{
    internal class ClientProfile:Profile
    {
        public ClientProfile()
        {
            CreateMap<ClientEntity, Client>();
        }
    }
}
