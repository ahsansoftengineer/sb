﻿using SB.Domain.HierarchyAggregate;
using SB.Domain.SimpleAggregates;

namespace SB.App.Common.Persistence.Hierarchy
{
  public interface ISystemzRepo : ISimpleRepo<Systemz>
  {
    Task<Systemz> GetById(SimpleValueObject id);
    Task<Systemz> GetByIdwithParent(SimpleValueObject id);
    Task<List<Systemz>> GetAll();
    Task<List<Systemz>> GetAllwithParent();
  }
}