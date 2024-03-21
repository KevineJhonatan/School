using School.Core.Entities;
using School.Core.JsonRequest.SuperAdmin;

namespace School.Core.Interfaces.Services
{
    public interface IAdminService
    {
        Admin Login(LoginReq request);
    }
}
