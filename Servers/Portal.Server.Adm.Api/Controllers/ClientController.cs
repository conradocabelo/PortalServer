using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Portal.InfraEstructure.Repository.Interfaces;
using Portal.Model.Clients;
using Portal.Server.Adm.Api.ViewModel.Clients;

namespace Portal.Server.Adm.Api.Controllers
{
    public class ClientController : BaseController
    {
        public ClientController(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        [HttpPost]
        public void NewClient(ClientViewModel clientViewModel)
        {
            var clientModel = Mapper.Map<Client>(clientViewModel);

            if (UnitOfWork.ClientRepository.FindClintById(clientModel.ClientId) != null)
                throw new InvalidOperationException("this client has already been registered");

            UnitOfWork.ClientRepository.Insert(clientModel);
            UnitOfWork.SaveChanges();
        } 
    }
}
