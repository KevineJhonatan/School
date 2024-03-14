using System.ComponentModel.DataAnnotations.Schema;

namespace School.Core.Entities
{
    [Table("Subject")]
    public class Subject : EntityBase
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual int ClassId { get; set; }
        public virtual Class? Class { get; set; }
    }
}
