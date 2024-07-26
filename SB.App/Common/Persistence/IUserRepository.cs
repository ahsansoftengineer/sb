using SB.Domain.Entities;

namespace SB.App.Common.Persistence
{
    public interface IUserRepository : ISimpleRepo<User>
    {
        User? GetUserByEmail(string email);
    }
}
