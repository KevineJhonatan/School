using School.Core;
using School.Core.Entities;
using School.Core.Exceptions;
using School.Core.Helpers;
using School.Core.Interfaces.Services;
using School.Core.JsonRequest.SuperAdmin;
using School.Core.JsonResponse;
using School.Infrastructure.Interfaces;
using Ecole = School.Core.Entities.School;

namespace School.Service
{
    public class SuperAdminService : ISuperAdminService
    {
        private readonly IGenericRepository<Ecole> _SchoolRepo;

        private readonly ISysParamValueRepository _SysParamRepo;

        private readonly IAdminRepo _AdminRepo;
        public SuperAdminService(IGenericRepository<Ecole> schoolRepo, ISysParamValueRepository sysParamRepo, IAdminRepo adminRepo)
        {
            _SchoolRepo = schoolRepo;
            _SysParamRepo = sysParamRepo;
            _AdminRepo = adminRepo;
        }
        public void CreateSchool(CreateSchoolReq request, int userId)
        {            
            if (string.IsNullOrEmpty(request.Name))
            {
                List<Error> errors = new List<Error>();
                var sysParamError = _SysParamRepo.FindByCode(Constants.SYSPARAM_ERRORS, Error.SCHOOL_NAME_ERROR_CODE.ToString());

                errors.Add(new Error { ErrorCode = Error.SCHOOL_NAME_ERROR_CODE, Message = sysParamError.LongText1, Source = sysParamError.ShortText1 });

                throw new ExceptionBase(errors);
            }

            _SchoolRepo.Insert(new Ecole { Name = request.Name, Description = request.Description, CreatedBy = userId });
            _SchoolRepo.Commit();
        }

        public Admin Login(LoginReq request)
        {
            if(string.IsNullOrEmpty(request.Login) || string.IsNullOrEmpty(request.Password))
            {
                throw new ExceptionBase(new List<Error> { new Error { ErrorCode = Error.INVALID_LOGIN_PASSWORD_ERROR_CODE, Message = "Invalid Login or Password", Source = "Credentials" }});
            }

            request.Login = request.Login.Trim();
            var admin = _AdminRepo.FindByLogin(request.Login, request.Password.HashPassword());
            if(admin is null || !admin.IsSuper)
            {
                throw new ExceptionBase(new List<Error> { new Error { ErrorCode = Error.INVALID_LOGIN_PASSWORD_ERROR_CODE, Message = "Invalid Login or Password", Source = "Credentials" } });
            }

            return admin;
        }
    }
}
