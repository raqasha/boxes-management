using Krd4.Models;

namespace Krd4.Services.Interfaces
{
    //interfejs ma publiczne metody.

    public interface IUserService : IService<User>
    {
        User Login(string login, string password);
    }
}
