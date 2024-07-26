﻿using SB.Domain.HierarchyAggregate;
using SB.Domain.SimpleAggregates;

namespace SB.App.Common.Persistence.Hierarchy
{
  public interface IOrgRepo : ISimpleRepo<Org>
  {
    Task<Org> GetById(SimpleValueObject id);
    Task<List<Org>> GetAll();
    Task<List<Org>> GetAllwithChilds();
  }
}
