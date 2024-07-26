using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SB.API.Controllers.Base;
using SB.Domain.DTOs.Hierarchy;
using SB.Infra.Entity.Hierarchy;
using SB.Infra.UOW;

namespace SB.API.Controllers.Hierarchy
{
    [Route("api/[controller]")]
  [ApiController]
  public class SystemzController : BaseController<SystemzController, Systemz, SystemzDtoSearch, SystemzDto, SystemzDtoCreate>
  {
    public SystemzController(
      ILogger<SystemzController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.Systemzs;

    }
  }
}