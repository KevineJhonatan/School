using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.JsonRequest.SuperAdmin
{
    public class UpdateAdminPasswordReq
    {
        public int AdminId { get; set; }
        public string NewPassword { get; set; }
    }
}
