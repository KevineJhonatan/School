using System.ComponentModel.DataAnnotations.Schema;

namespace School.Core.Entities
{
    [Table("SysParam")]
    public class SysParam : EntityBase
    {
        public string Code { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
