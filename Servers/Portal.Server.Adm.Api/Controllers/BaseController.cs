using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Portal.InfraEstructure.Repository.Interfaces;

namespace Portal.Server.Adm.Api.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class BaseController: ControllerBase
    {
        protected readonly IUnitOfWork UnitOfWork;
        protected readonly IMapper Mapper;

        public BaseController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }
    }
}