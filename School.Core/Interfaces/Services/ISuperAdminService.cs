using School.Core.Entities;
using School.Core.JsonRequest.SuperAdmin;

namespace School.Core.Interfaces.Services
{
    public interface ISuperAdminService
    {
        void CreateSchool(CreateSchoolReq request, int userId);

        Admin Login(LoginReq request);

        string GeneratePassword();

        void CreateAdmin(CreateAdminReq request, int userId);
        
    }
}
