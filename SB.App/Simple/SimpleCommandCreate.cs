using ErrorOr;
using MediatR;

namespace SB.App.Simple
{
  public record SimpleCommandCreate<TEntity>(
    string Title,
    string Description) : IRequest<ErrorOr<TEntity>>;

  public record SimpleCommandChildCreate<TEntity>(
    Guid ParentId,
    string Title,
    string Description) : IRequest<ErrorOr<TEntity>>;
}
