using School.Core.Entities;
using School.Core.JsonRequest.Admin;
using School.Core.JsonRequest.SuperAdmin;

namespace School.Core.Interfaces.Services
{
    public interface IAdminService
    {
        Admin Login(LoginReq request);

        void CreateSchoolYear(CreateSchoolYearReq request, int userId);

        void CreateClass(CreateClassReq request, int userId);
    }
}
