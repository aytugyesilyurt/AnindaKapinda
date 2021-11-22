using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService : IService<User>
    {
        User UserLogin(string mail, string password);
    }
}
