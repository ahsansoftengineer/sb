using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SB.Domain.Common;
using SB.Infra.Entity.Base;
using SB.Infra.UOW;

namespace SB.API.Controllers.Base
{
    [Route("api/[controller]")]
  [ApiController]
  public class CommonController<TController, TEntity> : BaseController<TController, TEntity, CommonDtoSearch, CommonDto, CommonDtoCreate>
    where TController : class
    where TEntity : BaseEntity
  {
    public CommonController(
      ILogger<TController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    { 

    }
  }
}