using SB.App.Simple;
using SB.Domain.HierarchyAggregate;

namespace SB.App.Hierarchy.Commands
{
  public class CreateOrgCommandValidator : SimpleCommandValidatorCreate<Org> { }
  public class CreateSystemzCommandValidator : SimpleCommandValidatorChildCreate<Systemz> { }
}
