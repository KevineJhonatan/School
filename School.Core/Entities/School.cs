using System.ComponentModel.DataAnnotations.Schema;

namespace School.Core.Entities
{
    [Table("School")]
    public class School : EntityBase
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
