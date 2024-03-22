using School.Core.Entities;
using School.Core.Exceptions;
using School.Core.Helpers;
using School.Core.Interfaces.Services;
using School.Core.JsonRequest.Admin;
using School.Core.JsonRequest.SuperAdmin;
using School.Core.JsonResponse;
using School.Infrastructure.Interfaces;
using Ecole = School.Core.Entities.School;

namespace School.Service
{
    public class AdminService : IAdminService
    {

        private readonly ISysParamValueRepository _SysParamRepo;
        private readonly IAdminRepo _AdminRepo;

        private readonly IGenericRepository<Ecole> _SchoolRepo;

        private readonly IGenericRepository<Admin> _GenericAdminRepo;

        private readonly IGenericRepository<SchoolYear> _GenericSchoolYearRepo;

        public AdminService(ISysParamValueRepository sysParamRepo, IAdminRepo adminRepo, IGenericRepository<Ecole> schoolRepo, IGenericRepository<Admin> genericAdminRepo, IGenericRepository<SchoolYear> genericSchoolYearRepo)
        {
            _SysParamRepo = sysParamRepo;
            _AdminRepo = adminRepo;
            _SchoolRepo = schoolRepo;
            _GenericAdminRepo = genericAdminRepo;
            _GenericSchoolYearRepo = genericSchoolYearRepo;

        }

        public void CreateSchoolYear(CreateSchoolYearReq request, int userId)
        {
            if((request.EndDate - request.StartDate).TotalDays < 30)
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.INVALID_SCHOOLYEAR_DATE_ERROR_CODE) });

            var school = _SchoolRepo.Find(id: request.SchoolId).FirstOrDefault();

            if(school is null)
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.INEXISTING_SCHOOL_ERROR_CODE, $" SchoolId = {request.SchoolId}") });

            var currentUser = _GenericAdminRepo.Find(id: userId).FirstOrDefault();
            if(currentUser is null || currentUser.SchoolId != request.SchoolId)
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.INVALID_SCHOOL_APPARTENANCE_ERROR_CODE) });

            var newSchoolYear = new SchoolYear
            {
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                SchoolId = request.SchoolId,
                CreatedBy = userId
            };

            _GenericSchoolYearRepo.Insert(newSchoolYear);
            _GenericSchoolYearRepo.Commit();
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
