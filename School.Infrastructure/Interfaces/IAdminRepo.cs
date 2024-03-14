using School.Core.Entities;

namespace School.Infrastructure.Interfaces
{
    public interface IAdminRepo
    {
        Admin FindByLogin(string login, string password);
    }
}
