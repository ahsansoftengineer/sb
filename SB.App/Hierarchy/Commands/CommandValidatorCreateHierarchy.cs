using SB.App.Simple;
using SB.Domain.HierarchyAggregate;

namespace SB.App.Hierarchy.Commands
{
  public class CreateOrgCommandValidator : SimpleCommandValidatorCreate<Org> { }
  public class CreateSystemzCommandValidator : SimpleCommandValidatorChildCreate<Systemz> { }
  public class CreateBGCommandValidator : SimpleCommandValidatorCreate<BG> { }
  public class CreateLECommandValidator : SimpleCommandValidatorChildCreate<LE> { }
  public class CreateOUCommandValidator : SimpleCommandValidatorChildCreate<OU> {}
  public class CreateSUCommandValidator : SimpleCommandValidatorChildCreate<SU> { }
}
