using School.Core;
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

        private readonly ISysParamValueRepository _SysParamValueRepository;

        private readonly IGenericRepository<Class> _ClassRepo;

        public AdminService(ISysParamValueRepository sysParamRepo, IAdminRepo adminRepo, IGenericRepository<Ecole> schoolRepo, IGenericRepository<Admin> genericAdminRepo,
            IGenericRepository<SchoolYear> genericSchoolYearRepo, ISysParamValueRepository sysParamValueRepository, IGenericRepository<Class> classRepo)
        {
            _SysParamRepo = sysParamRepo;
            _AdminRepo = adminRepo;
            _SchoolRepo = schoolRepo;
            _GenericAdminRepo = genericAdminRepo;
            _GenericSchoolYearRepo = genericSchoolYearRepo;
            _SysParamValueRepository = sysParamValueRepository;
            _ClassRepo = classRepo;
        }

        public void CreateClass(CreateClassReq request, int userId)
        {
            if(string.IsNullOrEmpty(request.Name))
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.INVALID_CLASS_NAME_ERROR_CODE) });

            var school = _SchoolRepo.Find(id: request.SchoolId).FirstOrDefault();

            if (school is null || !(bool)school.IsActive)
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.INEXISTING_SCHOOL_ERROR_CODE, $" SchoolId = {request.SchoolId}") });

            var level = _SysParamValueRepository.FindAllValuesByCode(Constants.SYSPARAM_CLASS_LEVELS).FirstOrDefault(x => x.Id == request.LevelId);

            if (level is null)
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.INEXISTING_LEVEL_ERROR_CODE, $" LevelId = {request.LevelId}") });

            var newClass = new Class
            {
                Name = request.Name,
                Description = request.Description,
                Level_Id = request.LevelId,
                SchoolId = request.SchoolId,
                CreatedBy = userId
            };
            _ClassRepo.Insert(newClass);
            _ClassRepo.Commit();
        }

        public void CreateSchoolYear(CreateSchoolYearReq request, int userId)
        {
            if((request.EndDate - request.StartDate).TotalDays < 30)
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.INVALID_SCHOOLYEAR_DATE_ERROR_CODE) });

            var school = _SchoolRepo.Find(id: request.SchoolId).FirstOrDefault();

            if(school is null || !(bool)school.IsActive)
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
