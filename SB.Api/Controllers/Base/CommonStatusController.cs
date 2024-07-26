﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SB.Domain.Common;
using SB.Domain.Enums;
using SB.Infra.Entity.Base;
using SB.Infra.UOW;

namespace SB.API.Controllers.Base
{
  [Route("api/[controller]")]
  [ApiController]
  public class CommonStatusController<TController, TEntity> : BaseController<
  TController,
  TEntity,
  CommonStatusDtoSearch,
  CommonStatusDto,
  CommonStatusDtoCreate>
  where TController : class
  where TEntity : BaseStatusEntity
  {
    public CommonStatusController(
      ILogger<TController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork) { }

    [HttpPut("status/{id:int}")]
    public async Task<IActionResult> Status(int id, [FromBody] Status status)
    {
      if (!ModelState.IsValid || id < 1) return StatusInvalid();
      try
      {
        var item = await Repo.Get(q => q.Id == id);

        if (item == null) return UpdateNull();

        item.Status = status;
        Repo.Update(item);
        await UnitOfWork.Save();
        return Ok(item);
      }
      catch (Exception ex)
      {
        return CatchException(ex, nameof(Update));
      }
    }
  }
}