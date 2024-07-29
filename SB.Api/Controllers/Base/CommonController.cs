using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SB.Domain.Common;
using SB.Infra.UOW;
using SB.Domain.Entity.Base;


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