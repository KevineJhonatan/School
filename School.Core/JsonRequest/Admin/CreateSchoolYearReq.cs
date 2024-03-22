using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.JsonRequest.Admin
{
    public class CreateSchoolYearReq
    {
        public int SchoolId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }        
    }
}
