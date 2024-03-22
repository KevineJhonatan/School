using School.Core.Entities;
using School.Core.JsonResponse;

namespace School.Infrastructure.Interfaces
{
    public interface ISysParamValueRepository
    {
        SysParamValue FindValueByCode(string sysParamCode, string valueCode);

        IList<SysParamValue> FindAllValuesByCode(string sysParamCode);

        Error GetErrorByCode(int errorCode, string extensionMessage = "");
    }
}
