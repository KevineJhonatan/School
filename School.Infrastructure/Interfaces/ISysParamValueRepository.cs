using School.Core.Entities;

namespace School.Infrastructure.Interfaces
{
    public interface ISysParamValueRepository
    {
        SysParamValue? FindByCode(string sysParamCode, string valueCode);
    }
}
