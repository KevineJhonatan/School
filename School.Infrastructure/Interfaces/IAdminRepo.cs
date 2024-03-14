using School.Core.Entities;

namespace School.Infrastructure.Interfaces
{
    public interface IAdminRepo
    {
        Admin FindByLoginAndPassword(string login, string password);

        Admin FindByLogin(string login);
    }
}
