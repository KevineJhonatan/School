using School.Core.Entities;
using School.Core.Exceptions;
using School.Core.Helpers;
using School.Core.Interfaces.Services;
using School.Core.JsonRequest.SuperAdmin;
using School.Core.JsonResponse;
using School.Infrastructure.Interfaces;

namespace School.Service
{
    public class AdminService : IAdminService
    {

        private readonly ISysParamValueRepository _SysParamRepo;

        private readonly IAdminRepo _AdminRepo;

        public AdminService(ISysParamValueRepository sysParamRepo, IAdminRepo adminRepo)
        {
            _SysParamRepo = sysParamRepo;
            _AdminRepo = adminRepo;
        }
        public Admin Login(LoginReq request)
        {
            if (string.IsNullOrEmpty(request.Login) || string.IsNullOrEmpty(request.Password))
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.INVALID_LOGIN_PASSWORD_ERROR_CODE) });

            request.Login = request.Login.Trim();
            var admin = _AdminRepo.FindByLoginAndPassword(request.Login, request.Password.HashPassword());

            if (admin is null || !(bool)admin.IsActive)
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.INVALID_LOGIN_PASSWORD_ERROR_CODE) });

            return admin;
        }
    }
}
