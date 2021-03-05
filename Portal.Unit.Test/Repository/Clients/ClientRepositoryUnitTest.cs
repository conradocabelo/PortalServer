using Portal.InfraEstructure.Repository.Interfaces;
using Portal.Model.Clients;
using Portal.Unit.Test.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Portal.Unit.Test.Repository.Clients
{
    public class ClientRepositoryUnitTest : ContextFixture
    {
        public ClientRepositoryUnitTest(ContextFactory factory) : base(factory)
        {
        }

        private Client NewClient()
        {
            Client client = new Client
            {
                AcceptScope = new List<ClientScope> { new ClientScope() { ScopeLabel = "teste.scope" } },
                AcessTokenLifetime = 250,
                ClientName = "client teste",
                Description = "client test",
                LogoClientUri = "http:\\teste.jpg",
                TokenLifetime = 2580,
                Enable = true
            };

            unitOfWork.ClientRepository.Insert(client);
            unitOfWork.SaveChanges();
            return client;
        }

        [Fact]
        public void Step_01_NewClient()
        {
            Client client = NewClient();

            var clientPersisted = unitOfWork.ClientRepository.Find(client);

            Assert.NotNull(clientPersisted);
        }
       
        [Fact]
        public void Step_02_UpdateClient()
        {
            Client client = NewClient();

            client.ClientName = "updated test";
            client.AcceptScope.First().ScopeLabel = "update scope";

            unitOfWork.ClientRepository.Update(client);
            unitOfWork.SaveChanges();

            var clientUpdated = unitOfWork.ClientRepository.Find(client);

            Assert.Equal(client.ClientName, clientUpdated.ClientName);
            Assert.Equal(client.AcceptScope.First().ScopeLabel, clientUpdated.AcceptScope.First().ScopeLabel);
        }

        [Fact]
        public void Step_03_RemoveClient()
        {
            Client client = NewClient();

            unitOfWork.ClientRepository.Delete(client);
            unitOfWork.SaveChanges();

            var clientRemoved = unitOfWork.ClientRepository.Find(client);

            Assert.Null(clientRemoved);
        }

        [Fact]
        public void Step_04_ListAllClients()
        {
            Client client = new Client();

            var clientPersisted = unitOfWork.ClientRepository.Select(t => t == client);

            Assert.NotNull(clientPersisted);
        }
    }
}
