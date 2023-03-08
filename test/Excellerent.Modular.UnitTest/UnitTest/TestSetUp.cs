using Excellerent.Standard.Advanced.Client.Core;
using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Application.Helpers;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Tests.UnitTest
{
    public static class TestSetUp
    {
       public static Mock<IClientRepository> GetMockRepository()
        {
               List<ClientEntity> Clients = new List<ClientEntity>()
            {
                new ClientEntity
                {
                    Guid = Guid.NewGuid(),
                    Name = "test client 1",
                    Description = "test"
                },
                new ClientEntity
                {
                    Guid = new Guid("a184a3d5-7177-4a4d-921f-c682732b4c6b"),
                    Name = "test client 2",
                    Description = "test"
                }
            };
            var _mockRepository = new Mock<IClientRepository>();

            ClientEntity testClient = new ClientEntity();

            _mockRepository.Setup(r => r.Add(It.IsAny<ClientEntity>())).ReturnsAsync((ClientEntity client) =>
            {
                Clients.Add(testClient);
                return testClient;
            });

            _mockRepository.Setup(r => r.GetAllAsync(It.IsAny<PaginationParameters>()).Result).Returns(Clients);

            return _mockRepository;



        }
    }
}
