using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.JsonRequest.Admin
{
    public class CreateClassReq
    {
        public int SchoolId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int LevelId { get; set; }
    }
}
