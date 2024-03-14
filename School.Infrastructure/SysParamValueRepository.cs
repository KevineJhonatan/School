using Microsoft.EntityFrameworkCore;
using School.Core.Entities;
using School.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure
{
    public class SysParamValueRepository : GenericRepository<SysParamValue>, ISysParamValueRepository
    {
        public SysParamValueRepository(SchoolContext context) : base(context)
        {
        }

        public SysParamValue? FindByCode(string sysParamCode, string valueCode)
        {
            return _Context.SysParamValues.Include(x => x.SysParam).FirstOrDefault(x => x.SysParam != null && x.SysParam.Code == sysParamCode && (bool)x.SysParam.IsActive 
            && x.Code == valueCode && (bool)x.IsActive);
        }
    }
}
