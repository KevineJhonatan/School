using School.Core.Entities;
using School.Core.JsonResponse;

namespace School.Infrastructure.Interfaces
{
    public interface ISysParamValueRepository
    {
        SysParamValue FindByCode(string sysParamCode, string valueCode);

        Error GetErrorByCode(int errorCode, string extensionMessage = "");
    }
}
