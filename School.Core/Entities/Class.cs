using System.ComponentModel.DataAnnotations.Schema;

namespace School.Core.Entities
{
    [Table("Class")]
    public class Class : EntityBase
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Level_Id { get; set; }
        public virtual SysParamValue? Level { get; set; }

        public virtual int SchoolId { get; set; }
        public virtual School? School { get; set; }
    }
}
