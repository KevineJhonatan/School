using School.Core;
using School.Core.Entities;
using School.Core.Enums;
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

        private readonly IGenericRepository<Admin> _GenericAdminRepo;

        public SuperAdminService(IGenericRepository<Ecole> schoolRepo, ISysParamValueRepository sysParamRepo, IAdminRepo adminRepo, IGenericRepository<Admin> genericAdminRepo)
        {
            _SchoolRepo = schoolRepo;
            _SysParamRepo = sysParamRepo;
            _AdminRepo = adminRepo;
            _GenericAdminRepo = genericAdminRepo;
        }
        public void CreateSchool(CreateSchoolReq request, int userId)
        {
            if (string.IsNullOrEmpty(request.Name))
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.SCHOOL_NAME_ERROR_CODE) });

            _SchoolRepo.Insert(new Ecole { Name = request.Name, Description = request.Description, CreatedBy = userId });
            _SchoolRepo.Commit();
        }

        public void CreateAdmin(CreateAdminReq request, int userId)
        {
            List<Error> errors = new List<Error>();
            if (string.IsNullOrEmpty(request.Firstname))
                errors.Add(_SysParamRepo.GetErrorByCode(Error.INVALID_ADMIN_FIRSTNAME_ERROR_CODE));

            if (string.IsNullOrEmpty(request.Lastname))
                errors.Add(_SysParamRepo.GetErrorByCode(Error.INVALID_ADMIN_LASTNAME_ERROR_CODE));

            if (string.IsNullOrEmpty(request.Birthdate))
                errors.Add(_SysParamRepo.GetErrorByCode(Error.INVALID_ADMIN_DOB_ERROR_CODE));

            if (!DateTime.TryParseExact(request.Birthdate, Constants.DATE_FORMAT, null, System.Globalization.DateTimeStyles.None, out DateTime newDob))
                errors.Add(_SysParamRepo.GetErrorByCode(Error.INVALID_ADMIN_DOB_FORMAT_ERROR_CODE));

            if (string.IsNullOrEmpty(request.Gender) || (request.Gender.ToUpper() != ((char)Gender.Male).ToString() && request.Gender.ToUpper() != ((char)Gender.Female).ToString()))
                errors.Add(_SysParamRepo.GetErrorByCode(Error.INVALID_ADMIN_GENDER_ERROR_CODE));

            if (string.IsNullOrEmpty(request.Login))
                errors.Add(_SysParamRepo.GetErrorByCode(Error.INVALID_ADMIN_LOGIN_ERROR_CODE));

            if (string.IsNullOrEmpty(request.Password))
                errors.Add(_SysParamRepo.GetErrorByCode(Error.INVALID_ADMIN_PASSWORD_ERROR_CODE));

            if (errors.Any())
                throw new ExceptionBase(errors);

            request.Login = request.Login.Trim();
            var admin = _AdminRepo.FindByLogin(request.Login);
            if (admin is not null)
            {
                errors.Add(_SysParamRepo.GetErrorByCode(Error.EXISTING_ADMIN_LOGIN_ERROR_CODE, $" Login = '{request.Login}'"));
                throw new ExceptionBase(errors);
            }

            var school = _SchoolRepo.Find(request.SchoolId).FirstOrDefault();
            if (school is null || !school.IsActive.Value)
            {
                errors.Add(_SysParamRepo.GetErrorByCode(Error.INEXISTING_SCHOOL_ERROR_CODE, $" SchoolID = {request.SchoolId}"));
                throw new ExceptionBase(errors);
            }

            _GenericAdminRepo.Insert(new Admin
            {
                Firstname = request.Firstname,
                Lastname = request.Lastname,
                DOB = newDob,
                Gender = request.Gender.ToUpper()[0],
                Login = request.Login,
                Password = request.Password.HashPassword(),
                Description = request.Description,
                IsSuper = false,
                SchoolId = request.SchoolId,
                CreatedBy = userId
            });

            _SchoolRepo.Commit();
        }

        public string GeneratePassword()
        {
            Random random = new Random();
            string upper1 = ((char)random.Next('A', 'Z' + 1)).ToString();
            string lower1 = ((char)random.Next('a', 'z' + 1)).ToString();
            string specialChars = "@#$+*!?";
            string special1 = (specialChars[random.Next(specialChars.Length)]).ToString();
            int randomNumber = random.Next(1000, 9999);

            string upper2 = ((char)random.Next('A', 'Z' + 1)).ToString();
            string lower2 = ((char)random.Next('a', 'z' + 1)).ToString();
            string special2 = (specialChars[random.Next(specialChars.Length)]).ToString();

            return $"{upper1}{lower1}{special1}{randomNumber}{upper2}{lower2}{special2}";
        }

        public Admin Login(LoginReq request)
        {
            if (string.IsNullOrEmpty(request.Login) || string.IsNullOrEmpty(request.Password))
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.INVALID_LOGIN_PASSWORD_ERROR_CODE) });

            request.Login = request.Login.Trim();
            var admin = _AdminRepo.FindByLoginAndPassword(request.Login, request.Password.HashPassword());

            if (admin is null || !admin.IsSuper)
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.INVALID_LOGIN_PASSWORD_ERROR_CODE) });

            return admin;
        }

        public void UpdateAdminPassword(UpdateAdminPasswordReq request, int userId)
        {
            if (string.IsNullOrEmpty(request.NewPassword) || request.NewPassword.Length < Constants.PASSWORD_LENGTH)
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.INVALID_PASSWORD_LENGTH_ERROR_CODE) });

            var admin = _GenericAdminRepo.Find(id: request.AdminId).FirstOrDefault();

            if (admin is null)
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.INEXISTING_ADMIN_USER_ERROR_CODE, $" ID = {request.AdminId}") });

            admin.Password = request.NewPassword.HashPassword();

            _GenericAdminRepo.Update(admin);
            _GenericAdminRepo.Commit();
        }
    }
}