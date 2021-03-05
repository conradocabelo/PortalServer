using AutoMapper;
using Portal.Model.Clients;
using Portal.Server.Adm.Api.ViewModel.Clients;

namespace Portal.Server.Adm.Api.ViewModel.Mapper
{
    public class ClientsProfile : Profile
    {
        public ClientsProfile()
        {
            CreateMap<Client, ClientViewModel>().ReverseMap();
        }
    }
}
