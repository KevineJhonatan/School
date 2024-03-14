using Microsoft.EntityFrameworkCore;
using School.Core;
using School.Core.Entities;
using School.Core.JsonResponse;
using School.Infrastructure.Interfaces;

namespace School.Infrastructure
{
    public class SysParamValueRepository : GenericRepository<SysParamValue>, ISysParamValueRepository
    {
        public SysParamValueRepository(SchoolContext context) : base(context)
        {
        }

        public SysParamValue FindByCode(string sysParamCode, string valueCode)
        {
            return _Context.SysParamValues.Include(x => x.SysParam).FirstOrDefault(x => x.SysParam != null && x.SysParam.Code == sysParamCode && (bool)x.SysParam.IsActive 
            && x.Code == valueCode && (bool)x.IsActive);
        }

        public Error GetErrorByCode(int errorCode)
        {
            var sysparamError = _Context.SysParamValues.Include(x => x.SysParam).FirstOrDefault(x => x.SysParam != null && x.SysParam.Code == Constants.SYSPARAM_ERRORS && (bool)x.SysParam.IsActive
           && x.Code == errorCode.ToString() && (bool)x.IsActive);

            if (sysparamError is null)
                return new Error();

            return new Error
            {
                ErrorCode = errorCode,
                Message = sysparamError.LongText1,
                Source = sysparamError.ShortText1
            };
        }
    }
}
