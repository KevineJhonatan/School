using School.Core.JsonRequest.SuperAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Interfaces.Services
{
    public interface ISuperAdminService
    {
        void CreateSchool(CreateSchoolReq request, int userId);
    }
}
