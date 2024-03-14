using System.ComponentModel.DataAnnotations.Schema;

namespace School.Core.Entities
{
    [Table("SchoolYear")]
    public class SchoolYear : EntityBase
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual int SchoolId { get; set; }
        public virtual School? School { get; set; }
    }
}