using School.Core;
using School.Core.Exceptions;
using School.Core.Interfaces.Services;
using School.Core.JsonRequest.SuperAdmin;
using School.Core.JsonResponse;
using School.Infrastructure;
using School.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecole = School.Core.Entities.School;

namespace School.Service
{
    public class SuperAdminService : ISuperAdminService
    {
        private readonly IGenericRepository<Ecole> _SchoolRepo;

        private readonly ISysParamValueRepository _SysParamRepo;
        public SuperAdminService(IGenericRepository<Ecole> schoolRepo, ISysParamValueRepository sysParamRepo)
        {
            _SchoolRepo = schoolRepo;
            _SysParamRepo = sysParamRepo;
        }
        public void CreateSchool(CreateSchoolReq request, int userId)
        {            
            if (string.IsNullOrEmpty(request.Name))
            {
                List<Error> errors = new List<Error>();
                var sysParamError = _SysParamRepo.FindByCode(Constants.SYSPARAM_ERRORS, Error.SCHOOL_NAME_ERROR_CODE.ToString());
                errors.Add(new Error
                {
                    ErrorCode = Error.SCHOOL_NAME_ERROR_CODE,
                    Message = sysParamError.LongText1,
                    Source = sysParamError.ShortText1
                });

                throw new ExceptionBase(errors);
            }

            _SchoolRepo.Insert(new Ecole { Name = request.Name, Description = request.Description, CreatedBy = userId });
            _SchoolRepo.Commit();
        }
    }
}
