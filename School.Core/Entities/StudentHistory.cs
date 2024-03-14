using System.ComponentModel.DataAnnotations.Schema;

namespace School.Core.Entities
{
    [Table("StudentHistory")]
    public class StudentHistory : EntityBase
    {
        public int Number { get; set; }

        public virtual int ClassId { get; set; }
        public virtual Class? Class { get; set; }

        public virtual int StudentId { get; set; }
        public virtual Student? Student { get; set; }

        public virtual int SchoolYearId { get; set; }
        public virtual SchoolYear? SchoolYear { get; set; }
    }
}
